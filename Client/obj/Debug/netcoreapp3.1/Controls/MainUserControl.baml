   M S B A M L   `   `   `  ����A  =Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Client.ControlsClient.Controls  5      %    Client.Controls.MainUserControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Client.Controls     5      .��5      � .+�5	   
   �� 
�������.+�5
      �� -   5          ��Name$  ListView��5
      $��14(�6)   $��Verdana)�69   $��Center=�6N   $	��800��6k   $��
450,30,0,0q�6x   $	��Top=�6�   $	��700��6�   $��Visible=�6�   $
��True��6�    �� View 5      �� 5      .P�5      ��  �� Width$	 150��6)    �� DisplayMemberBinding 65   �� *
UserName+.��5      �� -   5        $%��Имя пользователя��5   4   6O   5      �� 5      $	 300��6)    65   �� *Text+.��5      �� $��Сообщение��63   5      �� 5      $	 250��6)    65   �� *Time+.��5      �� -   5        $��
Время��5   3   6C   5      5      5      �� 5      -   5         ��Name$ UserName��5      $��29��6(   $��3,30,0,0q�64   $�� ��6F    �� TextWrapping$
 Wrap=�6N   $	��384��6b   �� 5      $2��,Ввести имя пользователя��6   $
��Left=�67   $��14(�6R   $��Verdana)�6b   $��37��6w   $��3,70,0,0q�6�   $	��Top=�6�   $	��384��6�   �� 5      -   5        $ Message��5      $
��Left=�6'   $��94��6B   $��	3,200,0,0q�6N   $�� ��6a   $
 Wrap=�6i   $	��Top=�6}   $	��384��6�   �� 5      -   5        $��Отправить��5      $
��Left=�6)   $��37��6D   $��14(�6P   $��Verdana)�6`   $��	3,310,0,0q�6u   $	��Top=�6�   $	��384��6�   6�   �� 5      -   5        $ 	StartDate��5      $��29��6)   $��1200,70,0,0q�65   $�� ��6J   $
 Wrap=�6R   $	��300��6f   �� 5      $B��<Ввести начальную дату(дд.мм.гггг)��6   $
��Left=�6A   $��14(�6\   $��Verdana)�6l   $��37��6�   $��1200,110,0,0q�6�   $	��Top=�6�   $	��300��6�   �� 5      -   5        $ EndDate��5      $��29��6'   $��1200,170,0,0q�63   $�� ��6I   $
 Wrap=�6Q   $	��300��6e   �� 5       $@��:Ввести конечную дату(дд.мм.гггг)��6   $
��Left=�6@   $��14(�6[   $��Verdana)�6k   $��37��6�   $��1200,210,0,0q�6�   $	��Top=�6�   $	��300��6�   �� 5!      -	   5         ��Name$ 	DateCheck��5!      $��1480,38,0,0q�6*   6?   �� 5"      $;��5Выполнить сортировку по дате��6   $��16(�6;   $��Verdana)�6K   $
��Left=�6`   $��30��6{   $��1200,28,0,0q�6�   $	��Top=�6�   $	��270��6�   5#      5$      5%      