<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="footer.css">
    <link rel="stylesheet" href="header.css">
    <link rel="stylesheet" href="css1/verhuur.css">
    <script src="../php/java/verhuur.js"></script>
    <title>Document</title>
</head>
<body>
    <?php include('head.php') ?>
    <section>
        <div class="imgleft">
            <img class="imgverhuur" src="img\verhuur1.jpg" alt="bikes">
            <img class="imgverhuur" src="img\verhuur2.jpg" alt="bikes">
        </div>
        <form action="verhuur2.php">
            <table class="table">
                <tbody>
                    <?php
                    $lines = file('algemene info\fietsverhuur.txt');

                    for ($i = 0; $i < count($lines); $i++) {
                        echo "<td><input type='checkbox' id='fiets" . $i . "' name='names[]'onclick='checkboxClicked(this)' value='$lines[$i]'>$lines[$i]</td>";
                    }
                    ?>
                </tbody>
            </table>
            <input type="submit" value="Huur de fietsen">
        </form>
        <div class="imgright">
            <img class="imgverhuur" src="img\winkel1.jpg" alt="bikes">
            <img class="imgverhuur" src="img\winkel2.jpg" alt="bikes">
        </div>
    </section>
    <?php include('foot.php') ?>
</body>
</html>