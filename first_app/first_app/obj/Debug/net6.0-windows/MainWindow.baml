   M S B A M L   `   `   `  ����D  @first_app, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:first_app	first_app  5   	       first_app.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:first_app     5   	     � Title$  Revision - FirstApp��5   	   $	��400��6%   $	��600��62   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��2* �6   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   ��  �� Orientation$ Vertical=�6   $��10 5 0 0q�6,   .+�5      �� $ 
Horizontal=�6   .+�5      �� -   5         ��Name$ 	combo_box��5      ��5      �� *comboBoxItems+ �� SelectedItem 5      �� *selectedCbItem+�� 5      -   5         ��Name$ new_item_text_box��5      $	��110��5       $��	10 0 10 0q�5!      �� 5#      -   5         ��Name$ add_new_cb_item��5$      $	��ADD��5%      6#   5'      �� 5)      $ 
Horizontal=�6   $��	40 10 0 0q�62   .+�5+      �� -   5         ��Name$ selected_item_text_block��5,      $��Selected Item��5-      $��0 0 45 0q�5.      �� 50      -   5        $ select_cb_item��51      $��SELECT��52      6&   54      56      �� 58   
   $��1��6   $ Vertical=�6%   .+�5:      �� $��PASS GENERATOR��6   $
��Bold"�6.   	 �� TextAlignment$	 Center=�6@   �� 5<      $��10 5 0 0q�6   .+�5=      �� -   5        
 ��Name$
 	chb_lower��5=   0   $��
LOWER CASE��6   $	��2 5q�6C   �� 5>      -   5        $
 	chb_upper��5>   0   $��
UPPER CASE��6   $	��2 5q�6C   �� 5?      -   5        $
 
chb_digits��5?   ,   $��DIGITS��6    d� 	IsChecked$
 TrueY�6@   $	��2 5q�6Q   �� 5@      -	   5        $
 chb_special��5@   3   $��SPECIAL CHARS��6   $	��2 5q�6H   5A      5C      �� 5E   
   $��2��5F      $��Center=�5G      $��Center=�5H      .+�5J      �� -
   5        $��GENERATE��5L      �� 5N      -   5        $# generated_password_text_block��5O      $��PASSWORD��5P      $��0 10 0 0q�5Q      $
��Bold"�5R      5T      �� 5V   
   $��1��6   $��1��6"   $ Vertical=�62   .+�5X      �� $��RANDOM FROM LOGIN��6   $	 Center=�61   $
��Bold"�6H   �� 5Z      -   5        $ login_user_text_block��5[      $	��130��60   $��0 5 0 0q�6<   �� 5]      -   5        $
��RAND��5_      $��50��5`      $��0 10 0 0q�5a      �� 5c      -   5        $ random_login_text_block��5d      $��Random Login��5e      $��0 10 0 0q�5f      $	 Center=�5g      5i      �� 5k   
   $��1��5l      .+�5n      �� $��Select a radio button: ��5o      $
��Bold"�5p      $��10 0 0 0q�5q      �� 5s      $ 
Horizontal=�6   .+�5u      �� -   5         ��Name$ radio_group_stack_panel��5v      $ Vertical=�5w      $��10 5 0 0q�5x      .+�5z      	� -   5         	�Name$ 
radio_btn1��5{       	� 	GroupName$ 
radio_btns��5|      $��option1��5}      $��0 2 0 0q�5~      	� 5�      -   5        $ 
radio_btn2��5�      $ 
radio_btns��5�      $��option2��5�      $��0 2 0 0q�5�      5�      �� 5�      $ Vertical=�6   $��Center=�64   .+�5�      �� $ 
Horizontal=�5�      $��Center=�5�      $��15 0 0 0q�5�      .+�5�      �� -   5        $ new_radio_btn_text_box��5�      $	��100��5�      �� 5�      -   5        $��	NEW RADIO��5�      5�      �� 5�      $ 
Horizontal=�5�      $��15 2 0 0q�5�      .+�5�      �� -   5        $ radio_content_text_block��5�      $��Radio content��5�      $	 Center=�5�      $	��100��5�      �� 5�      -   5        $��CONTENT��5�      $��70��5�      5�      5�      5�      5�      5�      5�      