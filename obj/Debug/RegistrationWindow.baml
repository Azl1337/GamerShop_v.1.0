   M S B A M L   `   `   `  ����I  EGamerShop v1.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:GamerShop_v1._0GamerShop_v1._0  5   	   (    "GamerShop_v1._0.RegistrationWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:GamerShop_v1._0     5   	   -   5           
BaseWindow#��[  5   	     � Title$  Регистрация��5	   	   $	��450��6   $	��800��6*    � WindowStartupLocation$ CenterScreen=�6L   .��5
      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      .+�5   
   �� $��
Логин��6   �� 5   
   $��Пароль��6   $��1��6!   �� 5   
   $��Фамилия��6   $��2��6"   �� 5   
   $��Имя��6   $��3��6   �� 5    
   $��Отчество��6   $��4��6#   �� 5!   
   $%��Место проживания��6   $��5��6+   �� 5"   
   $��Дата рождения��6   $��6��6(   �� 5%   
   -   5         ��Name$ 	TBoxLogin��5%      $��0��6B   $��1��6O   $	��5 5q�6_   ��6%   �� *ClientLogin+6_   �� 5&   
   -   5        $ TBoxPassword��5&      $��1��6H   $��1��6U   $	��5 5q�6e   ��6(   �� *ClientPassword+6e   �� 5'   
   -   5        $ TBoxLastName��5'      $��2��6H   $��1��6U   $	��5 5q�6e   ��6(   �� *ClientLastName+6e   �� 5(   
   -   5        $ TBoxName��5(      $��3��6@   $��1��6M   $	��5 5q�6]   ��6$   �� *
ClientName+6]   �� 5)   
   -   5        $ CBoxPatronymic��5)      $��4��6L   $��1��6Y   $	��5 5q�6i   ��6*   �� *ClientPatronymic+6i   �� 5*   
   -   5        $ TBoxCityAccommodation��5*      $��5��6Z   $��1��6g   $	��5 5q�6w   ��61   �� *ClientCityAccommodation+6w   � 5+   
   $��6��6   $��1��6    5,      �� 5-      $	��210 �6#   �� 5.      �� 5/      $	��230 �6#   .+�51      (  "System.Windows.Controls.DatePicker  -   5          Name$ DPickerClientBirthDate��51      $��0��6b   $	��200��6r   $
��Left=�6~   $��Center=�6�   $	��5 5q�6�      SelectedDate 69   �� *ClientBirthDate+6�   �� 52      -	   5         ��Name$ BtnGenerate��52      $��Код��6*   $��Right=�68   $��Center=�6T   $��1��6o   $��5q�6   6�   �� 53      -
   5        $ TBoxIdetificationCode��53      $�� ��65   $��2��6=   $	��5 5q�6M   54      �� 57   
   $��9��6   $��1��6"    �� Orientation$ 
Horizontal=�62   $��Right=�6K   $��Center=�6g   .+�58      �� -   5        $ BtnOK��58      $��OK��6$   61   �� 59      -   5        $ 	BtnCancel��59      $��Cancel��6(   $��5 0 5 0q�6P   5:      5;      5<      