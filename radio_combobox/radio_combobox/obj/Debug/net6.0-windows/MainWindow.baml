   M S B A M L   `   `   `  ����I  Eradio_combobox, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:radio_comboboxradio_combobox  5   	       radio_combobox.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:radio_combobox     5   	     � Title$  Radio - Combobox��5   	   $	��350��6"   $	��600��6/   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      .+�5   
   �� .+�5      ��  �� Orientation$ Vertical=�6   $��10 5 0 0q�60   .+�5      �� $ 
Horizontal=�5      $��Center=�5      .+�5      �� -   5         ��Name$  new_combobox_item_text_box��5      $	��130��5      �� 5      -   5        $	��ADD��5!      $��50��5"      �� 5%      -   5        $��DISPLAY��5'      $��50��5(      5+      �� 5-      $ 
Horizontal=�5.      $��Center=�5/      .+�51      �� -   5         ��Name$ 	combo_box��52      $��80��53      $��
0 10 20 10q�54      $��Center=�55      ��56      �� *comboBoxItems+ �� SelectedItem 57      �� *selectedComboBoxItem+�� 5:      -   5         ��Name$! selected_cb_item_text_block��5;      $��Selected value��5<      $��Center=�5=      $
��Bold"�5>      5A      �� 5C      -   5        $  if_sth_selected_text_block��5D      $$��If option2 is selected display��5E       �� TextAlignment$ Center=�5F      $y�Hidden=�5G      5J      5L      �� 5N   
   $ Vertical=�6   $��1��6,   .+�5O      �� $ Vertical=�6   $��10 5 0 0q�60   .+�5Q      �� $ 
Horizontal=�5R      $��Center=�5S      .+�5U      �� -   5        $ new_radiobox_text_box��5V      $	��130��5W      �� 5Y      -   5        $	��ADD��5[      $��50��5\      �� 5_      -	   5        $��DISPLAY��5a      $��50��5b      5e      5g      �� 5i      -
   5        $) #selected_radio_btn_value_text_block��5j      $��Selected value from radio��5k      $ Center=�5l      $y�Hidden=�5m      $
��Bold"�5n      �� 5q      -   5        	 ��Name$	 radio_buttons_stack_panel��5r      $ Vertical=�5s      $��0 10 0 0q�5t      $��Center=�5u      .+�5w      	� -   5        
 	�Name$
 
radio_btn1��5x       	� 	GroupName$ 
radio_btns��5y      $��Option1��5z      	� 5|      -   5        $
 
radio_btn2��5}      $ 
radio_btns��5~      $��Option2��5      5�      5�      �� 5�   
   $��1��5�      $ Vertical=�5�      .+�5�      �� $'��!Select a club to display a logo: ��5�      $
��Bold"�5�      $��10 2 0 0q�5�      �� 5�      $ 
Horizontal=�5�      $��Center=�5�      $��	0 10 0 10q�5�      .+�5�      �� -   5        $ new_radio_club_text_box��5�      $	��130��5�      �� 5�      -   5        $	��ADD��5�      $��50��5�      �� 5�      -   5        $
��SHOW��5�      $��50��5�      5�      �� 5�      $ 
Horizontal=�5�      .+�5�      �� -   5        $	 radio_images_stack_panel��5�      $ Vertical=�5�      $��5 5 0 0q�5�      .+�5�      	� -   5        $
 	bvb_radio��5�      $ radio_clubs��5�      $	��BVB��5�       d� 	IsChecked$
 TrueY�5�      	� 5�      -   5        $
 bayern_radio��5�      $ radio_clubs��5�      $��BAYERN��5�      5�      �� 5�      -   5         ��Name$ image��5�      $!��../../../images/defualt.png��5�      $��Right=�5�      $��30��5�      $��	0 5 -50 0q�5�      5�      5�      �� 5�   
   $ Vertical=�5�      $��1��5�      $��1��5�      .+�5�      �� $!��Generate A Color For a Text��5�      $ Center=�5�      $
��bold"�5�      �� 5�      -   5        $	 checkbox_stack_panel��5�      $ Vertical=�5�      .+�5�      �� -   5         ��Name$	 red��5�      $	��Red��5�      �� 5�      -   5        $ green��5�      $��Green��5�      �� 5�      -   5        $
 blue��5�      $
��Blue��5�      �� 5�      -   5        $��GENERATE��5�      $��80��5�      5�      �� 5�      -   5        $ color_text_block��5�      $��RESULT TEXT��5�      $��0 10 0 0q�5�      $ Center=�5�      $��15(�5�      
���   �
�������5�      5�      5�      5�      