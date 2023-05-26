<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="shortcut icon" href="images/logo20x20.png" type="image/x-icon">
    <link rel="stylesheet" href="footer.css">
    <link rel="stylesheet" href="header.css">
    <link rel="stylesheet" href="css1/verhuur.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
    <title>Verhuur</title>
</head>

<body>

    <?php include('head.php') ?>
    <section>
        <div class="imgleft">
            <img class="imgverhuur" src="img\verhuur1.jpg" alt="bikes">
            <img class="imgverhuur" src="img\verhuur2.jpg" alt="bikes">
        </div>

        <form action="verhuur2.php" id="names" method="POST">

            <table class="table">
                <tbody>

                    <?php
                    $lines = file('algemene info\fietsverhuur.txt');

                    for ($i = 0; $i < count($lines); $i++) {

                        // echo "<td><input type='checkbox' name='names[]'onclick='checkboxClicked(this)' value='$lines[$i]'>$lines[$i]</td>";
                        echo "<td><input type='checkbox' id='chkbox' onclick='isChecked()' class='fiets" . $i . "' name='names[]' value='$lines[$i]'>$lines[$i]</td>";
                    }
                    ?>

                </tbody>
            </table>


            <input type="submit" id="BtnSubmit" value="Huur de fietsen">
        </form>

        <div class="imgright">
            <img class="imgverhuur" src="img\winkel1.jpg" alt="bikes">
            <img class="imgverhuur" src="img\winkel2.jpg" alt="bikes">
        </div>
    </section>

    <script type="text/javascript">
        $(document).ready(function() {
            $('#BtnSubmit').click(function() {
                checked = $("input[type=checkbox]:checked").length;

                if (!checked) {
                    alert("Kies een fiets");
                    return false;
                }

            });
        });
    </script>


    <script src="java/verhuur.js"></script>

    <?php include('foot.php') ?>

</body>

</html>