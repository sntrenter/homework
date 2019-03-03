package com.example.petadoptionappsamtrenter;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.CheckBox;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.TextView;


public class MainActivity extends AppCompatActivity {

    //radio group
    private RadioGroup RGPet;
    private RadioButton RBFidoDog;
    private RadioButton RBFluffyCat;
    //imageView
    private ImageView IVPet;
    //checkbox
    private CheckBox CBAdoptionFee;
    private CheckBox CBMicrochipFee;
    private CheckBox CBSpayingAndNeuteringFee;
    //textview
    private TextView TVTotalFees;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        //FindViewsByID
        RGPet = findViewById(R.id.radioGroupPet);
        RBFidoDog = findViewById(R.id.radioButtonFidoDog);
        RBFluffyCat = findViewById(R.id.radioButtonFluffyCat);
        IVPet = findViewById(R.id.imageViewPet);
        CBAdoptionFee = findViewById(R.id.checkBoxAdoptionFee);
        CBMicrochipFee = findViewById(R.id.checkBoxMicrochipFee);
        CBSpayingAndNeuteringFee = findViewById(R.id.checkBoxSpayingAndNeuteringFee);
        TVTotalFees = findViewById(R.id.textViewTotalFees);

        //event listeners
        RBFidoDog.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                IVPet.setImageResource(R.drawable.fido);
            }
        });
        RBFluffyCat.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                IVPet.setImageResource(R.drawable.fluffy);
            }
        });

        //
    }
    //set text of CheckBoxes
    //NOTE: step 28-iv makes no sense.
    public void prieviewPetAndSet(){

    }




    public void onButtonAdoptAPetClick(View view) {

    }
}
