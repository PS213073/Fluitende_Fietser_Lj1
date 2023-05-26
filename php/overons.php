<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="shortcut icon" href="images/logo20x20.png" type="image/x-icon">
    <link rel="stylesheet" href="footer.css">
    <link rel="stylesheet" href="header.css">
    <link rel="stylesheet" href="css1/overons.css">
    <title>Document</title>
</head>

<body>
    <?php include('head.php') ?>
    <section>
        <img src="img/historie1.jpg" alt="historie" class="historie">
        <h1>
            Over ons
        </h1>
        <p>
            <?php
            $myfile = fopen("algemene info\overons.txt", "r") or die("Unable to open file!");
            echo fread($myfile, filesize("algemene info\overons.txt"));
            fclose($myfile);

            ?>
        </p>

    </section>

    <?php include('foot.php') ?>

</body>

</html>