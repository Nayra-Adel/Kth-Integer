   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	    concepts_ass3_wpf!   CPL_assignment_3.MainWindow   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	     � Title$  
MainWindow��5   	   $	��500��6   $	��800��6)   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��auto �6   6.   �� 5	      $��* �6   6+   .+�5   
   �� $��0��6   
�������$��1q�64   ��5      �� 5       �� Color# � ��6"   ._�5      �� -   5         �� TabStripPlacement$
 Left=�5      ��5      �� 5      # � ��6&   .@�5      �� -   5        $��showProducts_tab��5      $��Show Products��63   6M   �� 5      -   5        $��addProduct_tab��5      $��Add Product��61   6H   �� 5      -   5        $��selectProduct_tab��5      $��Select Products��64   6O   �� 5      -   5        $��showBrands_tab��5      $��Show Brands��61   6H   �� 5      -   5        $��sortProducts_tab��5      $��Sort Products��63   6L   5      5      � 5   
   -   5        $��showProduct_grid��5      $��1��6'   $��10q�6Z   $��Center=�6f   $��Center=�6�   $y�Visible=�6�   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��products_datagrid��5         AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *product_name+  5      $ Category��6)    6;   �� *
category+  5       $ Price��6)    68   �� *price+  5!      $ brand��6)    68   �� *Brand.brand_name+5#      5$      � 5%   
   -	   5        $��addProduct_grid��5%      $��1��6&   $��Center=�66   $��Center=�6S   $y�	Collapsed=�6n   $��10q�6�   .+�5&      �� .+�5'      �� $��5q�6    �� Orientation$ 
Horizontal=�6(   .+�5(      �� $��Name: ��6   $��70��6-   6:   �� 5)      -
   5        $��name_txt��5)      $	��300��6.   6<   5*      �� 5+      $��5q�6   $ 
Horizontal=�6(   .+�5,      �� $��Price: ��6   $��70��6.   6;   �� 5-      -   5        $��	price_txt��5-      $	��300��6/   6=   5.      �� 5/      $��5q�6   $ 
Horizontal=�6(   .+�50      �� $��
Category: ��6   $��70��61   6>   �� 51      -   5        $��category_txt��51      $	��300��62   6@   52      �� 53      $��5q�6   $ 
Horizontal=�6(   .+�54      �� $��Brand: ��6   $��70��6.   6;   �� 55      -   5        $��brand_combo��55      $	��300��62   	 �� DisplayMemberPath$	 
brand_name��6V   
 �� SelectedValuePath$
 brand_id��6u   ��6>   �� 6�   56      �� 57      $��10q�6   $ 
Horizontal=�6)   $��Right=�6B   .+�58      �� -   5        $��addProduct_btn��58      $��Add Product��63   6k   59      5;      5<      � 5=   
   -   5        $��selectProducts_grid��5=      $��1��6*   $y�	Collapsed=�6:   $��Center=�6Q   $��Center=�6n   .+�5>      �� .+�5?      �� $��5q�6   $ 
Horizontal=�6(   .+�5@      �� $��Price: ��6   $��70��6.   6;   �� 5A      -   5        $��selectPrice_txt��5A      $	��300��65   6C   5B      �� 5C      $��10q�6   $ 
Horizontal=�6)   $��Right=�6B   .+�5D      �� -   5        $��filterProducts_btn��5D      $��Filter Products��67   6u   5E      �� 5F      $��10q�6   $	��340��6)   .+�5G        -   5        $��filterProduct_grid��5G       .   5H        5I      $
 Name��61    6?   �� *product_name+  5J      $ Category��61    6C   �� *
category+  5K      $ Price��61    6@   �� *price+  5L      $ brand��61    6@   �� *Brand.brand_name+5N      5O      5P      5Q      � 5R   
   -   5        $��showBrands_grid��5R      $��1��6&   $y�	Collapsed=�66   $��Center=�6M   $��Center=�6j   .+�5S        -   5        $��brands_datagrid��5S      60   5T      � 5U   
   -   5        $��sortProducts_grid��5U      $��1��6(   $y�	Collapsed=�68   $��Center=�6O   $��Center=�6j   .+�5V      �� .+�5W      �� $��5q�6   $ 
Horizontal=�6(   .+�5X      �� $��	Sort by: ��6   $��70��60   6=   �� 5Y      -   5        $��sortBy_combo��5Y      $	��170��63   .@�5Z      �� $
��Name��6'   68   �� 5[      $��Price��6'   69   5\      �� 5]      $��20,0,0,0q�6   $��Direction: ��6.   $��70��6D   6Q   �� 5^      -   5        $��direction_combo��5^      $	��170��66   .@�5_      �� $��	Ascending��6'   6=   �� 5`      $��
Descending��6'   6>   5a      5b      �� 5c      $��10q�6   $	��340��6)   .+�5d        -   5        $��sortBy_datagrid��5d       .   5e        5f      $
 Name��61    6?   �� *product_name+  5g      $ Category��61    6C   �� *
category+  5h      $ Price��61    6@   �� *price+  5i      $ brand��61    6@   �� *Brand.brand_name+5k      5l      5m      5n      5o      5p      