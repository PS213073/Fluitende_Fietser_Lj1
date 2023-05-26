<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="shortcut icon" href="images/logo20x20.png" type="image/x-icon">
    <link rel="stylesheet" href="footer.css">
    <link rel="stylesheet" href="header.css">
    <link rel="stylesheet" href="css1/winkelmaandje.css">

    <title>Document</title>
</head>

<body>
    <?php include('head.php') ?>

    <section>
        <div class="products-container">
            <div class="product-header">
                <h2 class="product-title">Product</h2>
                <h2 class="price">Price</h2>
                <h2 class="quantity">Quantity</h2>
                <h2 class="total"></h2>
            </div>
            <div class="products">
            </div>
        </div>
        <input type="submit" onclick="purchaseClicked()" value="Betalen">
    </section>

    <script src="java\winkelmaandje.js" defer></script>
    <?php include('foot.php') ?>
</body>

</html>