using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;



    // Deriving the Purchaser class from IStoreListener enables it to receive messages from Unity Purchasing.
    public class Purchaser : MonoBehaviour, IStoreListener
    {
        private static IStoreController m_StoreController;          // The Unity Purchasing system.
        private static IExtensionProvider m_StoreExtensionProvider; // The store-specific Purchasing subsystems.

        public static string PRODUCT_3000_COIN = "coin_3000";
        public static string PRODUCT_7000_COIN = "coin_7000";
        public static string PRODUCT_15000_COIN = "coin_15000";



        void Start()
        {
            // If we haven't set up the Unity Purchasing reference
            if (m_StoreController == null)
            {
                // Begin to configure our connection to Purchasing
                InitializePurchasing();
            }
        }

        public void InitializePurchasing()
        {
            // If we have already connected to Purchasing ...
            if (IsInitialized())
            {
                // ... we are done here.
                return;
            }

        // Create a builder, first passing in a suite of Unity provided stores.
        var builder = ConfigurationBuilder.Instance(StandardPurchasingModule.Instance());

        // Add a product to sell / restore by way of its identifier, associating the general identifier
        // with its store-specific identifiers.
        builder.AddProduct(PRODUCT_3000_COIN, ProductType.Consumable);
            builder.AddProduct(PRODUCT_7000_COIN, ProductType.Consumable);
            builder.AddProduct(PRODUCT_15000_COIN, ProductType.Consumable);   


        UnityPurchasing.Initialize(this, builder);
        }


    private bool IsInitialized()
        {
            // Only say we are initialized if both the Purchasing references are set.
            return m_StoreController != null && m_StoreExtensionProvider != null;
        }


    public void Buy_3000()
        {
           
            BuyProductID(PRODUCT_3000_COIN);
        }
    public void Buy_7000()
    {
        
        BuyProductID(PRODUCT_7000_COIN);
    }
    public void Buy_15000()
    {
        
        BuyProductID(PRODUCT_15000_COIN);
    }

    void BuyProductID(string productId)
        {
            // If Purchasing has been initialized ...
            if (IsInitialized())
            {
                // ... look up the Product reference with the general product identifier and the Purchasing 
                // system's products collection.
                Product product = m_StoreController.products.WithID(productId);

                // If the look up found a product for this device's store and that product is ready to be sold ... 
                if (product != null && product.availableToPurchase)
                {
                    Debug.Log(string.Format("Purchasing product asychronously: '{0}'", product.definition.id));
                    // ... buy the product. Expect a response either through ProcessPurchase or OnPurchaseFailed 
                    // asynchronously.
                    m_StoreController.InitiatePurchase(product);
                }
                // Otherwise ...
                else
                {
                    // ... report the product look-up failure situation  
                    Debug.Log("BuyProductID: FAIL. Not purchasing product, either is not found or is not available for purchase");
                }
            }
            // Otherwise ...
            else
            {
                // ... report the fact Purchasing has not succeeded initializing yet. Consider waiting longer or 
                // retrying initiailization.
                Debug.Log("BuyProductID FAIL. Not initialized.");
            }
        }

    public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
        {
            // Purchasing has succeeded initializing. Collect our Purchasing references.
            Debug.Log("OnInitialized: PASS");

            // Overall Purchasing system, configured with products for this application.
            m_StoreController = controller;
            // Store specific subsystem, for accessing device-specific store features.
            m_StoreExtensionProvider = extensions;
        }

    public void OnInitializeFailed(InitializationFailureReason error)
        {
            // Purchasing set-up has not succeeded. Check error for reason. Consider sharing this reason with the user.
            Debug.Log("OnInitializeFailed InitializationFailureReason:" + error);
        }


    public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
        {
            // A consumable product has been purchased by this user.
            if (String.Equals(args.purchasedProduct.definition.id, PRODUCT_3000_COIN, StringComparison.Ordinal))
            {
                Debug.Log(string.Format("ProcessPurchase: 3000", args.purchasedProduct.definition.id));

                Purchase.Ins.Chest_Fx();
                Purchase.Ins.CHEST_3();
                
                
            }
            
            else if (String.Equals(args.purchasedProduct.definition.id, PRODUCT_7000_COIN, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: 7000", args.purchasedProduct.definition.id));

            Purchase.Ins.Chest_Fx();
            Purchase.Ins.CHEST_7();

        }
        else if (String.Equals(args.purchasedProduct.definition.id, PRODUCT_15000_COIN, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: 15000", args.purchasedProduct.definition.id));

            Purchase.Ins.Chest_Fx();
            Purchase.Ins.CHEST_15();

        }

        // Or ... an unknown product has been purchased by this user. Fill in additional products here....
        else
            {
                Debug.Log(string.Format("ProcessPurchase: FAIL. Unrecognized product: '{0}'", args.purchasedProduct.definition.id));
            }

 
            // saving purchased products to the cloud, and when that save is delayed. 
            return PurchaseProcessingResult.Complete;
        }


    public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
        {
            
            Debug.Log(string.Format("OnPurchaseFailed: FAIL. Product: '{0}', PurchaseFailureReason: {1}", product.definition.storeSpecificId, failureReason));
        }

    }
