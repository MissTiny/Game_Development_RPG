using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopItemList
{
    public List<ShopItem> ShopItems;
    public ShopItemList(){
        ShopItems = new List<ShopItem>();


        ShopItems.Add(new ShopItem("Book",
        "A love story between the princess and her royal teacher. Girls may like reading this kind of novel",150));

        ShopItems.Add(new ShopItem("Cosmetic",
        "From a well-known makeup brand. Fashion girl's favorite",200));

        ShopItems.Add(new ShopItem("Music Record",
        "From a old famous singer. Music can revoke your youth memory!",120));

        ShopItems.Add(new ShopItem("Guitar",
        "Guitar for new learner!",250));

        ShopItems.Add(new ShopItem("Phone",
        "Famous Pear phone! You deserve it!",1000));

        ShopItems.Add(new ShopItem("Coffee",
        "StartBuck Tea, you own it!",25));

        ShopItems.Add(new ShopItem("Tea",
        "Black Tea",25));

        ShopItems.Add(new ShopItem("Luxury Bag",
        "This bag is designed for nobles!",1500));

        ShopItems.Add(new ShopItem("Snacks",
        "Eat some snacks to enjoy your life and reduce your anxiety",50));

        ShopItems.Add(new ShopItem("Lucky Candy",
        "Unknown candy from nowhere. Nobody knows the effect. Be careful before eating",100));

        ShopItems.Add(new ShopItem("Alcohol",
        "A good gift for people who drink alcohol! Not good for kids!",70));

        ShopItems.Add(new ShopItem("Smoke",
        "A good gift for people who smoke! Not good for kids",80));

    


    }
}
