   M S B A M L   `   `   `  ����L  Hbiegi_rejestracja, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:biegi_rejestracjabiegi_rejestracja  5   	   #    biegi_rejestracja.Rejestracja   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:biegi_rejestracja     5   	     � Title$  Rejestracja��5   	   $	��560��6   $	��400��6*   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   6+   �� 5      $	��49* �6   6-   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $	��49* �6   6+   �� 5      $��* �6   6)   .+�5   
   ��  �� Orientation$ Vertical=�6   $��1��6,   $��1��69   $��0 10 0 0q�6I   .+�5      �� $��Center=�6   $��15(�65   Imię:6J   �� 5      -   5         ��Name$
 imie��5      $
��auto��6$   $��
20 10 20 0q�61   6G   �� 5      $��Center=�6   $��15(�65   	Nazwisko:6N   �� 5      -   5        $ nazwisko��5      $
��auto��6(   $��
20 10 20 0q�65   6K   �� 5      $��Center=�6   $��15(�65   Login:6K   �� 5      -   5        $ login��5      $
��auto��6%   $��
20 10 20 0q�62   6H   �� 5      $��Center=�6   $��15(�65   $��	 0 10 0 0q�6C   	Hasło:6^   G� 5      -   5         G�Name$ haslo��5      $
��auto��6)   $��
20 10 20 0q�66   6L   �� 5!      $��Center=�6   $��15(�65   $��	 0 10 0 0q�6C   Powtórz hasło:6f   G� 5"      -   5        $ haslo1��5"      $
��auto��6*   $��
20 10 20 0q�67   6M   �� 5$      $��Center=�6   $��15(�65   $��	 0 10 0 0q�6C   	E-mail:6`   �� 5%      -   5        $ email��5%      $
��auto��6%   $��
20 10 20 0q�62   6H   �� 5'      $��Center=�6   $��15(�65   $��	 0 10 0 0q�6C   Data urodzenia:6g   (  "System.Windows.Controls.DatePicker  5(      -   5          Name$ data_ur��5(      $��
20 10 20 0q�6*   6A   �� 5*      $��Center=�6   $��15(�65   $��	 0 10 0 0q�6C   	Płeć:6]   �� 5,      $ 
Horizontal=�6   $��Center=�62   .+�5-      	� -   5         	�Name$ K��5-       	� 	GroupName$
 plec��6)   $��16(�6:   $��Center=�6H   .��6j   	Kobieta6s   	� 5.      -	   5        $ M��5.      $
 plec��6)   $��16(�6:   $��Center=�6H   $��10 0 0 0q�6j   .��6|   Mężczyzna6�   5/      �� 51      -
   5        	 ��Name$	 logowanie_msb��51      $��30��6,   $	��105��68   $��0 20 0 0q�6D   $��Zarejestruj się��6V   6�   53      54      55      