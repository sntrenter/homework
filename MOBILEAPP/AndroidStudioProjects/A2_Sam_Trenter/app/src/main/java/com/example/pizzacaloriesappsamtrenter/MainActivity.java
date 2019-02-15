package com.example.pizzacaloriesappsamtrenter;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.CheckBox;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {
    //class level constants
    final int CHEESE_CALORIES = 260;
    final int MUSHROOM_CALORIES = 30;
    final int BELLPEPPER_CALORIES = 30;
    final int PEPPERONI_CALORIES = 100;
    int totalPizzaCalories = 0;

    //class level constants
    private CheckBox checkBoxCheese;
    private CheckBox checkBoxMushroom;
    private CheckBox checkBoxBellPepper;
    private CheckBox checkBoxPepperoni;
    private TextView totalPizzaCaloriesTextView;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        checkBoxCheese = findViewById(R.id.checkBoxCheese);
        checkBoxMushroom = findViewById(R.id.checkBoxMushroom);
        checkBoxBellPepper = findViewById(R.id.checkBoxBellPepper);
        checkBoxPepperoni = findViewById(R.id.checkBoxPepperoni);
        totalPizzaCaloriesTextView = findViewById(R.id.totalPizzaCaloriesTextView);
    }

    public void onButtonFindTotalPizzaCaloriesClick(View view) {
        totalPizzaCalories = 0;
        if(checkBoxCheese.isChecked()){totalPizzaCalories += CHEESE_CALORIES;}
        if(checkBoxMushroom.isChecked()){totalPizzaCalories += MUSHROOM_CALORIES;}
        if(checkBoxBellPepper.isChecked()){totalPizzaCalories += BELLPEPPER_CALORIES;}
        if(checkBoxPepperoni.isChecked()){totalPizzaCalories += PEPPERONI_CALORIES;}
        totalPizzaCaloriesTextView.setText("The total calories is:"+Integer.toString(totalPizzaCalories));
    }


}
