   M S B A M L   `   `   `  ����K  GParcial_Ing_Soft, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Parcial_Ing_SoftParcial_Ing_Soft  5   	       Parcial_Ing_Soft.prueba   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Parcial_Ing_Soft     5   	   -   5          � Title$  prueba��5   	   $	��450��6   $	��800��6%    � 	Resources 5	      /   )Parcial_Ing_Soft.inmobiliaria_2018DataSet   inmobiliaria_2018DataSet  duenioViewSource �� Source �� Source  inmuebleViewSource  dataTable1ViewSource��%�   &	        &	      7   &	 ?     7   &	 m     7     5
   
   6)   �� 5   
    68   �� *duenio+8   �� 5   
    6:   �� *
inmueble+8   �� 5   
    6<   �� *
DataTable1+8   5      .��5      �  � DataContext# [ 6   .+�5   
   � -   5         �Name$ grid1��5      # [ 6   $
��Left=�6R   $��
35,280,0,0q�6m   $	��Top=�6�    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#    � RowDefinitions 5      �� 5      $
��Auto �6    .+�5      �� $��calle inmueble:��6   $��0��6.   $
��Left=�6>   $��3q�6Y   $��0��6d   $��Center=�6q   �� 5      -   5         ��Name$ calle_inmuebleTextBox��5      $��1��65   $
��Left=�6E   $��23��6`   $��3q�6l   $��0��6w   $��Center=�6�   $	��120��6  ��6�   �� *calle_inmueble+	 �� Mode$	 TwoWay=�
 �� NotifyOnValidationError
 .  �� ValidatesOnExceptions . 6  5      � 5   
   -   5        $ grid2��5      # [ 6   $
��Left=�6R   $��454,283,0,0q�6m   $	��Top=�6�    5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#    5       �� 5!      $
��Auto �6    .+�5#      �� $��telefono duenio:��6   $��0��6/   $
��Left=�6?   $��3q�6Z   $��0��6e   $��Center=�6r   �� 5$      -   5        $ telefono_duenioTextBox��5$      $��1��66   $
��Left=�6F   $��23��6a   $��3q�6m   $��0��6x   $��Center=�6�   $	��120��6  ��6�   �� *telefono_duenio+$	 TwoWay=�
 .  . 6  5%      � 5&   
   -   5        $ grid3��5&      # [ 6   $
��Left=�6R   $��
31,333,0,0q�6m   $	��Top=�6�    5'      �� 5(      $
��Auto �6#   �� 5)      $
��Auto �6#    5+      �� 5,      $
��Auto �6    .+�5.      �� $��nomb duenio:��6   $��0��6+   $
��Left=�6;   $��3q�6V   $��0��6a   $��Center=�6n   �� 5/      -   5        $ nomb_duenioTextBox��5/      $��1��62   $
��Left=�6B   $��23��6]   $��3q�6i   $��0��6t   $��Center=�6�   $	��120��6   ��6�   �� *nomb_duenio+$	 TwoWay=�
 .  . 6   50      �� 51   
   -   5        $��buttonPrevious��51      $��Anterior��6=   $
��Left=�6P   $��407,382,0,0q�6k   $	��Top=�6�   $��75��6�   �� 52   
   -	   5        $��
buttonNext��52      $��	Siguiente��68   $
��Left=�6L   $��528,382,0,0q�6g   $	��Top=�6|   $��75��6�   �� 53   
   -
   5        $��buttonFirst��53      $��Primer Registro��6:   $
��Left=�6T   $��309,382,0,0q�6o   $	��Top=�6�   $��75��6�   �� 54   
   -   5        $��
buttonLast��54      $��Ultimo Registro��68   $
��Left=�6R   $��627,382,0,0q�6m   $	��Top=�6�   $��75��6�   �� 55   
   -   5         �� SelectedValue$
 sada��55       �� SelectedItem$
 ewqs��6(   $
��Left=�6<   $��369,333,0,0q�6X   $	��Top=�6m   $	��120��6�    �� Text$ As��6�   &   System.Windows.Media.TextOptions   TextHintingMode$ Fixed=�6�   &   System.Windows.Controls.DataGrid  56   
   -   5          Name$ duenioDataGrid��56         AutoGenerateColumns .     EnableRowVirtualization . $��170,40,222,179q�6~      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ��6f   ��    Columns 57      0  *System.Windows.Controls.DataGridTextColumn  58      -   5        dni_duenioColumn��,  &System.Windows.Controls.DataGridColumn   Header$ 
dni duenio��58   ^      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6r   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *
dni_duenio+6r     59      -   5        nomb_duenioColumn��$ nomb duenio��59   `   $ SizeToHeader 6u    6@   �� *nomb_duenio+6u     5:      -   5        apellido_duenioColumn��$ apellido duenio��5:   h   $ SizeToHeader 6�    6D   �� *apellido_duenio+6�     5;      -   5        telefono_duenioColumn��$ telefono duenio��5;   h   $ SizeToHeader 6�    6D   �� *telefono_duenio+6�   5=      5>      5?      