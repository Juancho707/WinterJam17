using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class OrderUI : MonoBehaviour
{
    private OrderClock clock;
    private FormOrder form;
    private Order myOrder;
    private OrderIngredients ingredients;

    private void Start()
    {
        clock = this.GetComponentInChildren<OrderClock>();
        form = this.GetComponentInChildren<FormOrder>();
        ingredients = this.GetComponentInChildren<OrderIngredients>();

        myOrder = new Order();
        form.DisplayForm(myOrder);
        ingredients.DisplayIngredients(myOrder);
    }
}
