<?php
// gebruik: https://www.w3schools.com/php/php_file_open.asp
$kleuren = fopen("lijst.txt", "r") or die("Kan het bestand niet openen!");
echo fread($kleuren,filesize("lijst.txt"));
fclose($kleuren);
echo "<br>";

// loopje
echo "<select>";
$kleuren = fopen("lijst.txt", "r") or die("Kan het bestand niet openen!");
$i = 0;
while(!feof($kleuren)) {
    echo "<option value=$i>" . fgets($kleuren) . "</option>";
    $i++;
  }
fclose($kleuren);
echo "</select>";
?>