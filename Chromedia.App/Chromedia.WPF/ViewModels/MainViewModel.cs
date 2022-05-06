using Chromedia.Business.BusinessLogic.Interfaces;
using ReactiveUI;
using System.Reactive.Linq;
using Console = System.Console;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Threading;
using Chromedia.Business.Models;

namespace Chromedia.WPF.ViewModels
{
    public class MainViewModel : ReactiveObject
    {
        private readonly IArticleLogic _articleLogic;
        private string _outputString;
        private string _inputLimit;
        private bool _limitEnabled;
        private List<Article> _articles;
        public List<Article> Articles
        {
            get => _articles;
            set => this.RaiseAndSetIfChanged(ref _articles, value);
        }

        /// <summary>
        /// CHROMEDIASEARCH:
        /// This variable is binded to the input textbox and is responsible for managing the number of rows to be displayed.
        /// </summary>
        public string InputLimit
        {
            get => _inputLimit;
            set => this.RaiseAndSetIfChanged(ref _inputLimit, value);
        }

        public bool LimitEnabled
        {
            get => _limitEnabled;
            set => this.RaiseAndSetIfChanged(ref _limitEnabled, value);
        }

        /// <summary>
        /// CHROMEDIASEARCH:
        /// This variable is for the output found on the righthand side of the window.
        /// </summary>
        public string OutputString
        {
            get => _outputString;
            set => this.RaiseAndSetIfChanged(ref _outputString, value);
        }

        public MainViewModel(IArticleLogic articleLogic)
        {
            _articleLogic = articleLogic;
            LoadData();

            this.WhenAnyValue(x => x.InputLimit)
                .Where(x => !string.IsNullOrEmpty(x))
                .Subscribe(limit =>
                {
                    Articles = _articleLogic.GetLimitArticles(Int32.Parse(limit));
                    OutputString = GetOutputString(Articles);
                });

            this.WhenAnyValue(x => x.Articles)
                .Where(x => x != null)
                .Subscribe(x => LimitEnabled = x.Any());;
        }

        private string GetOutputString(List<Article> articles)
        {
            var outputString = string.Empty;
            foreach (var article in Articles)
            {
                var title = !string.IsNullOrEmpty(article.Title) ? article.Title : article.StoryTitle;

                if (!string.IsNullOrEmpty(title))
                {
                    outputString += $"{title}\n";
                }
            }

            return outputString;
        }

        /// <summary>
        /// CHROMEDIASEARCH:
        /// This method is only done one time when opening the app and is responsible for caching the Articles so as not to keep on asking for the data everytime the input changes.
        /// Caching happens on line 99.
        /// </summary>
        private void LoadData()
        {
            Task.Run(() => _articleLogic.GetAll())
                .ContinueWith(task =>
                {
                    var data = task.Result.ToList();
                    _articleLogic.SetCachedArticles(data);
                    Articles = data;
                });
        }
    }
}
