   M S B A M L   `   `   `  ����I  EGamerShop v1.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:GamerShop_v1._0GamerShop_v1._0  5   	   !    GamerShop_v1._0.LoginWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:GamerShop_v1._0     5   	   -   5           LoginWindow#��[  5   	     � Title$  Авторизация��5	   	   $	��230��6   $	��470��6*    � WindowStartupLocation$ CenterScreen=�5
   	   .��5      �  � RowDefinitions 5   
   �� 5      $��28 �6   �� 5      $��* �6   �� 5      $��35 �6   .+�5   
   �� $��Вход��6   � 5   
   $��1��6    5      �� 5      �� 5       � ColumnDefinitions 5      �� 5      $	��100 �6#   �� 5      .+�5      �� $��Логин :��6   �� 5       -   5         ��Name$ 	TBoxLogin��5       $��0��6)   $��1��66   $��azl1337��6F   �� 5!      $��Пароль :��6   $��1��6'   G� 5"      -   5         G�Name$ PBoxPassword��5"      $��1��60   $��1��6=   $
��5 15q�6M    G� Password$	 azl��6[   5$      �� 5&   
   $��2��6    �� Orientation$ 
Horizontal=�6"   $��Right=�5'      $��Center=�61   .+�5(      �� -   5         ��Name$ BtnReg��5(      $��Регистрация��6%   $
��Left=�6;   $	��100��5)   2   �� 5*      -   5        $ BtnOK��5*      $��OK��6$   $��5 0 0 0q�6D   �� 5+      -   5        $ 
BtnRecover��5+      $��Восстановить��6)   $��5 0 10 0q�6@   $	��100��5,   -   	 � ToolTip$�	 �Перед нажатием на эту кнопку, необходимо ввести логин восстанавливаемого аккаунта!��5-      5.      �� 50   
   $��2��6   $ 
Horizontal=�6"   $
��Left=�6;   $	��Top=�6V   $��5q�6n   .+�51      �� $!��Запомнить меня��6   $��2��6.   $��10(�6;   $��Center=�6I   �� 52      -   5        
 ��Name$
 ChkBox��52      $��Center=�6'   53      54      55      