   M S B A M L   `   `   `  ����H  DPrimerAPP WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:PrimerAPP_WPFPrimerAPP_WPF  5   	       PrimerAPP_WPF.Pagos   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:PrimerAPP_WPF     5   	     � Title$  Pagos��5   	   $	��550��6   $	��380��6$    � 
ResizeMode$ CanMinimize=�5	   	    � 	Resources 5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ Dictionary1.xaml?�6%   �� 5      $e _pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Light.xaml?�6%   �� 5      $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Defaults.xaml?�6%   �� 5      $z tpack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Primary/MaterialDesignColor.DeepPurple.xaml?�6%   �� 5      $s mpack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Accent/MaterialDesignColor.Lime.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $
��0.7* �6   .+�5   
   �� $(��"C:/Users/mramirez/Desktop/Pago.png��6    J� Opacity$	 0.1Q�6<   5      � 5   
   $��0��6    5      �� 5       �� 5!      �� 5"      .+�5&      � $��0��6    5'      �� 5(      �� 5)      .+�5+      �� $��1��6    �� Orientation$ 
Horizontal=�6*   $
��Left=�6C   $��Center=�6^   .+�5,      �� -   5        $��LB_Tipo��5,      $
��Tipo��6+   $��6,0,0,0q�6:   �� 5-      -   5        $��CB_Tipo��5-      $��90��6.   $��25��69   $��10,0,0,0q�6E   .@�5.      �� $��Crear��6'   �� 5/      $��Abonar��6'   50      �� 51      -   5        $��LB_Por��51      $	��Por��6*   $��10,0,0,0q�68   �� 52      -   5        $��CB_Por��52      $��90��6-   $��25��68   $��10,0,0,0q�6D   53      54      �� 55      $��0��6   $ 
Horizontal=�6+   $
��Left=�6D   $��Center=�6_   .+�56      �� -   5        $��LB_IngMensu��56      $��Ingresos Mensuales��6+   $��10,0,0,0q�6H   �� 57      -   5        $��TB_IngMensu��57      $��90��6-   $��25��68   $��10,0,0,0q�6D   .��6V   58      59      5:      � 5=      $��1��6    5>      �� 5?      �� 5@      .+�5B      �� $��1��6   $ 
Horizontal=�6*   $
��Left=�6C   $	��Top=�6^   .+�5C      �� -   5        $��LB_FechaIni��5C      $��Fecha Inicial��6/   $��6,0,0,0q�6G   (  "System.Windows.Controls.DatePicker  5D      -   5        $��DP_FechaIni��5D   !   $��90��64   $��25��6?   $��10,0,0,0q�6K   �� 5G      -	   5        $��LB_FechaFin��5G      $��Fecha Final��6/   $��10,0,0,0q�6E     5H      -
   5        $��DP_FechaFin��5H   !   $��90��64   $��25��6?   $��10,0,0,0q�6K   5K      �� 5L      $��1��6   $ 
Horizontal=�6*   $
��Left=�6C   $	��Top=�6^   .+�5N      �� -   5        $��LB_Cuota��5N      $��Cuota��6,   $��	215,0,0,0q�6<   �� 5O      -   5        $��TB_Cuota��5O      $��90��6.   $��25��69   $��10,0,0,0q�6E   5Q      5T      5W      � 5Y   
   $��1��6   $	��216��6   $��0,0,0,25q�6*   .+�5Z      &   System.Windows.Controls.DataGrid  -   5          Name$
 DG_1��5Z      5[      � 5]   
   $��1��6   $��25��6   $��	0,187,0,0q�6(   .+�5^      ��  -  )MaterialDesignToolBarMainPanelBorderStyle#��[  6   $��1q�6X   
�������$��0,0,0,0q�6�   ._�5_      �� -   5        $��
LB_Version��5_      $��Versión 1.0.0��6*   5`      5a      5d      5e      