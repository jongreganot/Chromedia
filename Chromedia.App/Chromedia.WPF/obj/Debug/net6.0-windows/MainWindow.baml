   M S B A M L   `   `   `  ����H  DChromedia.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Chromedia.WPFChromedia.WPF  5   	       Chromedia.WPF.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Chromedia.WPF     5   	   -   5        $��ThisControl��5	   	     � Title$  
MainWindow��5   	   $	��578��6   $
��1110��6)   .��5
      �  � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��900 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6"    �� Orientation$ 
Horizontal=�5      .+�5      �� -   5         ��Name$ 	LimitText��5      $
��Left=�5      $��Center=�5      $��25��5      $	��150��5      {�5      �� *LimitEnabled+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=���5      �� *
InputLimit+$ TwoWay=�$ PropertyChanged=�5      �� 5      $��Center=�5      $G��A<------- Please input here after data loads for about 5-8 seconds��5       5!      &   System.Windows.Controls.DataGrid  5#   
   -   5        $��ArticleGrid��5$      $��1��5#      $��0��6       AutoGenerateColumns$ False��5%      ��5&      �� *
Articles+$ TwoWay=�$ PropertyChanged=�   Columns 5'      0  *System.Windows.Controls.DataGridTextColumn  5(      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Title��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 300 64   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� *Title+  5)      $	 Story Title��6%   $	
 300 6:    6F   �� *
StoryTitle+  5*      $	 Number Of Comments��6%   $	
 300 6A    6M   �� *NumberOfComments+5,      �� 5-   
   $��0��6   $��2��6!   $��1��62   �� 5.      $�Output is here: ��6   �� 5/      �� 50      �6   �� *OutputString+$ TwoWay=�$ PropertyChanged=�51      52      53      