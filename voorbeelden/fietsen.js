var popupViews = document.querySelectorAll('.popup-view');
var popupBtns = document.querySelectorAll('.popup-btn');
var closeBtns = document.querySelectorAll('.close-btn');

//javascript for quick view button
var popup = function (popupClick) {
    popupViews[popupClick].classList.add('active');
}

popupBtns.forEach((popupBtn, i) => {
    popupBtn.addEventListener("click", () => {
        popup(i);
    });
});

//javascript for close button
closeBtns.forEach((closeBtn) => {
    closeBtn.addEventListener("click", () => {
        popupViews.forEach((popupView) => {
            popupView.classList.remove('active');
        });
    });
});

if (document.readyState == 'loading') {
    document.addEventListener('DOMContentLoaded', ready)
} else {
    ready()
}


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
    let productContainer = document.querySelector(".products");let cartCost = localStorage.getItem('totalCost');
    if (cartItems && productContainer) {
        productContainer.innerHTML = '';
        Object.values(cartItems).map(item => {
            productContainer.innerHTML += `
         <div class="product"> 
         <ion-icon name="close-circle-outline"></ion-icon>
         <img src="fietsen/${item.tag}.jpg">
         <span>${item.name}</span>
         </div>
         <div class="price">€${item.price}</div>
         <div class="quantity">
         <ion-icon name="caret-back-outline"></ion-icon>
         <span>${item.inCart}</span>
         <ion-icon name="caret-forward-outline"></ion-icon>
         </div>
         <div class="total">
         €${item.inCart * item.price},00
         </div>
        `
        });

        productContainer.innerHTML += `
        <div class="basketTotalContainer">
        <h4 class="basketTotalTitle">
        Basket Total
        </h4>
        <h4 class="basketTotal">
        €${cartCost},00
        </h4>
        </div>
        `
    }

    
}


displayCart()