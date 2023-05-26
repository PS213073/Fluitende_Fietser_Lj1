let carts = document.querySelectorAll('.add-cart-btn');

let products = [
    {
        name: 'Pelikaan Carry',
        tag: 'pelikaancarry',
        price: 769,
        inCart: 0
    },
    {
        name: 'Allegra voorwielmotor',
        tag: 'allegravoorwielmotor',
        price: 999,
        inCart: 0
    },
    {
        name: 'Gazelle Orange C7',
        tag: 'gazelleorange',
        price: 2199,
        inCart: 0
    },
    {
        name: 'Gazelle CityGo C7',
        tag: 'gazellecityGo',
        price: 679,
        inCart: 0
    }
]
for (let i = 0; i < carts.length; i++) {
    carts[i].addEventListener('click', () => {
        cartNumbers(products[i]);
        totalCost(products[i]);
    })
}
function cartNumbers(product) {
    let productNumbers = localStorage.getItem('cartNumbers');
    productNumbers = parseInt(productNumbers);
    if (productNumbers) {
        localStorage.setItem('cartNumbers', productNumbers + 1);
    }
    else {
        localStorage.setItem('cartNumbers', 1);
    }
    setIetms(product);
}

function setIetms(product) {
    let cartItems = localStorage.getItem('productsInCart');
    cartItems = JSON.parse(cartItems);

    if (cartItems != null) {

        if (cartItems[product.tag] == undefined) {
            cartItems = {
                ...cartItems,
                [product.tag]: product
            }
        }
        cartItems[product.tag].inCart += 1;
    }
    else {

        product.inCart = 1;
        cartItems = {
            [product.tag]: product
        }
    }

    localStorage.setItem("productsInCart", JSON.stringify(cartItems));
}

function totalCost(product) {
    let cartCost = localStorage.getItem('totalCost');


    if (cartCost != null) {
        cartCost = parseInt(cartCost);
        localStorage.setItem("totalCost", cartCost + product.price);
    }
    else {
        localStorage.setItem("totalCost", product.price);
    }

}

function displayCart() {
    let cartItems = localStorage.getItem("productsInCart");
    cartItems = JSON.parse(cartItems);
    let productContainer = document.querySelector(".products"); let cartCost = localStorage.getItem('totalCost');
    if (cartItems && productContainer) {
        productContainer.innerHTML = '';
        Object.values(cartItems).map(item => {
            productContainer.innerHTML += `
         <div class="product"> 
         <svg xmlns="http://www.w3.org/2000/svg" onclick="ready()" class="ioniconclose" viewBox="0 0 512 512"><title>Close Circle</title><path d="M448 256c0-106-86-192-192-192S64 150 64 256s86 192 192 192 192-86 192-192z" fill="none" stroke="currentColor" stroke-miterlimit="10" stroke-width="32"/><path fill="none" stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="32" d="M320 320L192 192M192 320l128-128"/></svg>
         <img class="javaimg" src="java/img/${item.tag}.jpg">
         <span class="sname">${item.name}</span>     
         <div class="price">€${item.price}</div>
         <div class="quantity">
         <svg xmlns="http://www.w3.org/2000/svg" class="ioniconback" viewBox="0 0 512 512"><title>Caret Back</title><path d="M321.94 98L158.82 237.78a24 24 0 000 36.44L321.94 414c15.57 13.34 39.62 2.28 39.62-18.22v-279.6c0-20.5-24.05-31.56-39.62-18.18z"/></svg>
         <span>${item.inCart}</span>
         <svg xmlns="http://www.w3.org/2000/svg" class="ioniconforward" viewBox="0 0 512 512"><title>Caret Forward</title><path d="M190.06 414l163.12-139.78a24 24 0 000-36.44L190.06 98c-15.57-13.34-39.62-2.28-39.62 18.22v279.6c0 20.5 24.05 31.56 39.62 18.18z"/></svg>
         </div>
         <div class="total">
         €${item.inCart * item.price},00
         </div>
         </div> 
        `
        });

        productContainer.innerHTML += `
        <div class="basketTotalContainer">
        <h4 class="basketTotalTitle">
        Totaal
        </h4>
        <h4 class="basketTotal">
        €${cartCost},00
        </h4>
        </div>
        `
    }
}


function purchaseClicked() {
    alert('Bedankt voor uw aankoop')
    var cartItems = document.getElementsByClassName('products')[0]
    while (cartItems.hasChildNodes()) {
        cartItems.removeChild(cartItems.firstChild)
    }

}

displayCart()


