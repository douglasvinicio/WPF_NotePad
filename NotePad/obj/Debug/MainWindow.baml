   M S B A M L   `   `   `  ����B  >NotePad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:NotePadNotePad  5   	       NotePad.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:NotePad     5   	   $	��450��5   (   $	��800��65     � Title  6	   ��  �� Path$ MyTitle�.��5
      ]� .+�5   
   o� $	��Top=�6   .@�5      m� $
��File��6   .@�5      m� -   5        $��
miOpenFile��5   )   $
��Open��6   6V   m� 5      -   5        $��miSave��5   )   $
��Save��6   6N   m� 5      -   5        $��
miSaveFile��5   .   $��	Save as..��6   6[   �� 5      6   m� 5      -   5        $��	miExitApp��5   )   $
��Exit��6   6T   5      5      �� 5   
   $��Bottom=�6   .@�5      �� .��5      �� -   5        $��	tblStatus��5   3   $��No File to open��6   6F   5      5      �� 5   
   -   5        $��txtValue��5   '    �� AcceptsReturn . 6\   5      5      