   M S B A M L   `   `   `  ���� C  ?project2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:project2project2      project2.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:project2     -     � Title$  
MainWindow��$	��450��$	��800��.��� .+�� ���#89cff0$��75��$	��Top=�.+��� $#��/Assets/Afbeeldingen/logo.png��$
��Left=�$��25,0,0,0q��� $	��150��$��Center=�$
��Left=�$��	110,0,0,0q�.+��� $��24(� �� TextAlignment$ Center=�De fluitende�� $��24(�$ Center=�	fietser� $	��350��$	��300��$��25q�$��Bottom=�$
��Left=�.+��� -    ��Name$ 	cbFietsen��$��25��$	��175��$
��Left=�$	��Top=�.@��� .��Aanhangfiets�� .��
Bakfiets�� .��Driewielfiets�� .��Elektrische fiets�� .��Kinderfiets�� .��
Ligfiets�� .��	Oma fiets�� .��	Racefiets�� .��Speed pedelec�� .��
Stadsfiets�� .��	Vouwfiets�� .��
Zitfiets�� -    ��Name$ tbPrijsFiets��$��112.5,5q�$��25��$��50��$��Right=�$	��Top=�$ Center=��� -    ��Name$ 	btFietsen��$��25��$	��100��$��Right=�$	��Top=�.��	Toevoegen�� -   $ cbVerzekering��$��25��$	��175��$
��Left=�$	��Top=�$
��0,35q�.@��� .��Beschadigingen�� .��
Diefstal�� .��Rechtsbijstand�� .��
Ongevallen�� -   $ tbPrijsVerzekering��$��112.5,40q�$��25��$��50��$��Right=�$	��Top=�$ Center=��� -   $ btVerzekering��$��25��$	��100��$��Right=�$	��Top=�$
��0,35q�.��	Toevoegen�� -   $ 	cbService��$��25��$	��175��$
��Left=�$	��Top=�$
��0,70q�.@��� .��Ophaalservice�� .��
Regenpak�� .��Lunchpakket basis�� .��Lunchpakket uitgebreid�� -	   $ tbPrijsService��$��112.5,75q�$��25��$��50��$��Right=�$	��Top=�$ Center=��� -
   $ 	btService��$��25��$	��100��$��Right=�$	��Top=�$
��0,70q�.��	Toevoegen�� -    ��Name$ lbBestelling��$	��175��$��Bottom=�.@��� $
��Bold"�Bestelling:� $	��350��$	��300��$��25q�$��Bottom=�$��Right=�.+���  �� Orientation$ Vertical=�.+��� $ Center=�$��24(�	Totaal:�� -   $ tbkPrijs��$ Center=�$��20(�
€ 0,00�� $ Center=�$��0,10,0,0q�Bedrag handmatig invoeren:�� -    ��Name$ tbPrijs��$��75�� �� TextAlignment$ Center=�.���� -   $ btSelecteerGeld��$��25��$	��100��$
��0,20q�.��Geld selecteren�� -   $ 	btBetalen��$��50��$	��150��$��Bottom=�.��	Betalen