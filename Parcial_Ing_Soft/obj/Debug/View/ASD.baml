   M S B A M L   `   `   `  ����K  GParcial_Ing_Soft, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Parcial_Ing_Soft.HelpersParcial_Ing_Soft.Helpers  5   	   G(clr-namespace:Parcial_Ing_Soft.ViewModelParcial_Ing_Soft.ViewModel  5   	   $    Parcial_Ing_Soft.ViewModel.ASD   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   :helpers&clr-namespace:Parcial_Ing_Soft.Helpers     5   	   7vm(clr-namespace:Parcial_Ing_Soft.ViewModel     5   	      ViewModelMain  � DataContext#  �   5   	    � Title$# Inmobiliaria - Final Ing Soft��5   	   $	��450��6/   $	��813��6<    � Topmost .  � WindowStartupLocation$ CenterScreen=�6W    � 	Resources 5	      .  (Parcial_Ing_Soft.ViewModel.ViewModelMain��%   &	          5
   
   6   5      ��5      �� 5   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ Black��6    � Offset$ 0Q�6)   � 5      $ 	#FFE8D685��6   $ 1Q�6-   5      .��5      � 	 � RowDefinitions	 5   
   �� 5      $	��66* �6   �� 5      $
��318* �6   �� 5      $	��35* �6   .+�5   
   �� $��	Inmuebles��6   $��Center=�6&   $��Center=�6C   $	��262��6^   $��10,33,10,23q�6k   $	��785��6�   
�������$��1��6�   ���	#FFFFFDFD$��SemiBold"�6�   .��5      � 
 � ColumnDefinitions
 5      �� 5      $
��157* �6'   �� 5      $
��166* �6'   	 5       �� 5!      �� 5"      $
��Auto �6$   .+�5$      �� $
��Auto=�6   $��2��6B   .��5%      �� .+�5&      �� $
��Bold"�6K   $��5q�6]   $��Inmueble en: '��6h     6$   �� *SelectedPerson+�� 6   �6�   �� *Barrio+�� 6�   $�'��6�   6�   �� 5'       �� Orientation$ 
Horizontal=�6%   .+�5)      ��  �� DisplayMemberPath$ Dueño��6m   $
��Left=�6�   ��6&   �� *People+ �� SelectedItem 6E   �� *SelectedPerson+6�   &   System.Windows.Controls.DataGrid  5*      $
��Left=�6n   $��5,0,0,0q�6�   ��6'   �� *People+ 6F   �� *SelectedPerson+6�   �� 5+      $ Dueño��6n   $��5,0,0,5q�6�   $	��Top=�6�   ��6'   �� *People+ 6F   �� *SelectedPerson+6�   5,      5-      5.      50      51      � 53   
   $��0��6   $��0,10,0,0q�6!   ��55      �� 56       �� ImageSource$) #../Imagenes/inmobiliario_titulo.jpg��6    j� Stretch$ Uniform=�6O   .+�58      �� -   5        $��37��58   2   $��40��6>   ��59      �� 5:      $ /Imagenes/boton_atras.ico��6!   5<      5>      � 5?   
   $��Center=�6   $��Center=�61   $��2��6M   $��26��6Z   $��261,6,261,3q�6f   $	��270��6{   .+�5@      �� $7��1Final Ing Soft | Alumno: Ramos Mauricio | IFTS 18��6   $��Segoe UI Emoji)�6P   6n   5A      5D      5E      