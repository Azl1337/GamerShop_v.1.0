   M S B A M L   `   `   `  ����I  EGamerShop v1.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:GamerShop_v1._0.PagesGamerShop_v1._0.Pages  5      *    $GamerShop_v1._0.Pages.ClientListPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:GamerShop_v1._0.Pages     5      -   5          N� Title$  ClientListPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $	��10* �6   �� 5      $��50 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGridClient��5         AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6B      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6N   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *
IdClient+6N     5      $ Фамилия��6H   $ 5* 6Y    6%   �� *ClientLastName+6Y     5      $ Имя��6D   $ 5* 6Q    6%   �� *
ClientName+6Q     5      $ Отчество��6J   $ 5* 6\    6%   �� *ClientPatronymic+6\     5      $ Роль��6H   $ 5* 6V    6%   �� *Role.RoleTitle+6V     5      $ 
Логин��6E   $ 5* 6T    6%   �� *ClientLogin+6T     5      $ Пароль��6H   $ 5* 6X    6%   �� *ClientPassword+6X   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 auto 6)   $  Редактировать��66   	   CellTemplate	 5      �� 5      .R�5      �� 
 ��Name$

 Edit��6%   -   5        $ ��Редактировать��5   3   $	��100��6`   5      5!      5#      �� 5%   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   $��Center=�6V   .+�5&      �� -   5        $
 btnAdd��5&      $��Добавить��6%   $��5q�6M   �� 5'      -   5        $
 	btnDelete��5'      $��Удалить��6(   $��5q�6Q   5(      5)      5*      