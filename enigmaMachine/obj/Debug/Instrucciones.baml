   M S B A M L   `   `   `  ����H  DenigmaMachine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:enigmaMachineenigmaMachine  5   	   !    enigmaMachine.Instrucciones   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:enigmaMachine     5   	     � Title$  Instrucciones��5   	   $	��740��6   $	��822��6,   ���	#FFEDF2F9$	��822��6O   $	��740��6^    � WindowStartupLocation$ CenterScreen=�6n    � 
ResizeMode$ NoResize=�6�    � WindowStyle$
 None=�6�   .��5	      � .+�5
   
   �� $��Instrucciones��6   $
��Left=�6(   $��	67,30,0,0q�6C   $	��Top=�6V   $��42(�6n   $��0,5,5,5q�6|   �� 5   
   -   5        $�� ��5       � ToolTip$ Volver a inicio��6      MyButton#��[  66   $
��Left=�6X   $��
714,10,0,0q�6s   $	��Top=�6�   $��27��6�   ���	#FF1F47F0$��24��6�   ��5      �� 5       �� ImageSource$ Imagenes/arrow-back.png��6   5      �� 5   
   $
��Left=�6   $	��565��60   $��
67,112,0,0q�6=   $	��Top=�6Q   $	��679��6i   .@�5      �� $��
Encriptado��6   $��16(�6*   ���	#FFA8C2E7���	#FF5A86FF.��5      � ���	#FFDCE9FA.+�5      �� $��56,39,331.6,0q�6    $
��Wrap=�67   $����Selecciona las letras de partida de cada rotor con ayuda de sus respectivas flechas. Cuando ya las tengas, éstas serán el código de partida para que luego tú o alguien más pueda desencriptar tu texto, así que debes recordarlas.��6K   $	��Top=�66  $��16(�6N  �� 5      $	��1.-��6   $
��Left=�6*   $��	14,30,0,0q�6E   $	��Top=�6X   $��39��6p   $��37��6|   $��20(�6�   $
��Bold"�6�   �� 5      $
��Left=�6   $��93��67   $��
355,45,0,0q�6C   $	��Top=�6W   $	��294��6o   $"��Imagenes/rotores-rounded.png��6{   �� 5      $	��2.-��6   $
��Left=�6*   $��349,225,0,0q�6E   $	��Top=�6Z   $��39��6r   $��37��6~   $��20(�6�   $
��Bold"�6�   �� 5      $��394,234,25.6,0q�6    $
��Wrap=�68   $	��Top=�6L   $��16(�6d   $��72��6r   $f��`Ingresa tu texto a encriptar con los botones del teclado del programa (no se incluyen espacios).��6~   �� 5      $
��Left=�6   $	��109��67   $��
25,217,0,0q�6D   $	��Top=�6X   $	��310��6p   $��Imagenes/keyboard.png��6|   �� 5      $	��3.-��6   $
��Left=�6*   $��
21,369,0,0q�6E   $	��Top=�6Y   $��39��6q   $��37��6}   $��20(�6�   $
��Bold"�6�   �� 5      $��63,378,297.6,0q�6    $
��Wrap=�68   $	��Top=�6L   $��16(�6d   $	��103��6r   $����Encontrarás el texto que estás ingresando en el campo "texto de entrada" y su encriptación en "texto encriptado". Listo! Terminaste!��6   �� 5      $
��Left=�6   $	��154��67   $��381,357,0,0q�6D   $	��Top=�6Y   $	��260��6q   $��Imagenes/campos.png��6}   5      5      �� 5      $��Desencriptado��6   $��16(�6-   ���	#FFA8C2E7���	#FF5A86FF.��5      � ���	#FFDCE9FA.+�5       �� $	��1.-��6   $
��Left=�6*   $��	16,20,0,0q�6E   $	��Top=�6X   $��39��6p   $��37��6|   $��20(�6�   $
��Bold"�6�   �� 5!      $��57,25,323.6,0q�6    $
��Wrap=�67   $	��Top=�6K   $��16(�6c   $����Coloca cada letra del código de partida en su respectivo rotor con ayuda de las flechas, el código será el mismo con el que encriptaste tu texto (o el texto que alguien más encriptó) y lo necesitas para poder desencriptarlo o la desencriptación será diferente a la que esperabas.��6q   �� 5"      $
��Left=�6   $��93��67   $��
361,45,0,0q�6C   $	��Top=�6W   $	��294��6o   $"��Imagenes/rotores-rounded.png��6{   �� 5#      $	��2.-��6   $
��Left=�6*   $��348,226,0,0q�6E   $	��Top=�6Z   $��39��6r   $��37��6~   $��20(�6�   $
��Bold"�6�   �� 5$      $��393,234,18.6,0q�6    $
��Wrap=�68   $	��Top=�6L   $��16(�6d   $��72��6r   $i��cIngresa tu texto a desencriptar con los botones del teclado del programa (no se incluyen espacios).��6~   �� 5%      $
��Left=�6   $	��109��67   $��
24,218,0,0q�6D   $	��Top=�6X   $	��310��6p   $��Imagenes/keyboard.png��6|   �� 5&      $	��3.-��6   $
��Left=�6*   $��
24,366,0,0q�6E   $	��Top=�6Y   $��39��6q   $��37��6}   $��20(�6�   $
��Bold"�6�   �� 5'      $��66,376,294.6,0q�6    $
��Wrap=�68   $	��Top=�6L   $��16(�6d   $	��103��6r   $����Encontrarás el texto encriptado que estás ingresando en el campo "texto de entrada" y su desencriptación en "texto encriptado". Listo! Terminaste!��6   �� 5(      $
��Left=�6   $	��154��67   $��384,354,0,0q�6D   $	��Top=�6Y   $	��260��6q   $��Imagenes/campos.png��6}   5)      5*      �� 5+      $��Otros��6   $��16(�6%   ���	#FFA8C2E7���	#FF5A86FF.��5,      � ���	#FFDCE9FA.+�5-      �� $��45,62,281.6,0q�6    $
��Wrap=�67   $r��l- Si te equivocaste, puedes usar el botón de "borrar caracter" para borrar la última letra que ingresaste.��6K   $	��Top=�6�   �� 5.      $��291,188,28.6,0q�6    $
��Wrap=�68   $	��Top=�6L   $����- Si quieres encriptar o desencriptar un nuevo texto pero borrar letra por letra sería un fastidio, puedes hacer click en "reiniciar" para borrar todo lo que ingresaste anteriormente y poner los rotores en su valor iniial.��6d   �� 5/      $
��Left=�6   $��65��67   $��
406,60,0,0q�6C   $	��Top=�6W   $	��237��6o   $��Imagenes/btn-borrar.png��6{   �� 50      $
��Left=�6   $��63��67   $��
32,203,0,0q�6C   $	��Top=�6W   $	��237��6o   $ ��Imagenes/btn-reiniciar.png��6{   51      52      53      �� 54   
   -   5        $�� ��54      $ 	Minimizar��6   #��[  60   $
��Left=�6R   $��
746,10,0,0q�6m   $	��Top=�6�   $��22��6�   $��22��6�   ��6�   Z� ��55      �� 56      $ Imagenes/minimizar.png��6   58      �� 59   
   -   5        $�� ��59      $ Cerrar��6   #��[  6-   $
��Left=�6O   $��
773,10,0,0q�6j   $	��Top=�6~   $��22��6�   $��22��6�   ��6�   Z� ��5:      �� 5;      $ Imagenes/close.png��6   5=      5?      5@      