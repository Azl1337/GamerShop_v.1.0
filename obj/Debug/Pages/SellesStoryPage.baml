   M S B A M L   `   `   `  ����I  EGamerShop v1.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:GamerShop_v1._0.PagesGamerShop_v1._0.Pages  5      +    %GamerShop_v1._0.Pages.SellesStoryPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:GamerShop_v1._0.Pages     5        N� Title$  SellesStoryPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5   
   $��* �6    � RowDefinitions 5      �� 5   
   $
��auto �6   �� 5   
   $��* �6   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��2��6*   &   System.Windows.Controls.DataGrid  5"      -   5          Name$ 
DGridSells��5"         AutoGenerateColumns .  $��1��6?   $��1��6O      
IsReadOnly .    Columns 5#   
   0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn   Header$ Игра��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6T   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 63   �� *GetGameTitle+6T     5%      $ Ключ��6%   $	 90 6P   
 63   �� *
Key.Key1+6P     5&      $ Дата продажи��6!   
 67   �� *
SaleDate+ �� StringFormat$ d�� �� ConverterCulture$ ru-RU��  5'      $ Клиент��6!   $	 90 6O   
 61   �� *	GetClient+6O   5)      5*      5+      