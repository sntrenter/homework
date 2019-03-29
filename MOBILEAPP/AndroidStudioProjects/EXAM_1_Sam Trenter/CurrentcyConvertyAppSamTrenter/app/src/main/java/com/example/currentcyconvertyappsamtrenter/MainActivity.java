package com.example.currentcyconvertyappsamtrenter;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {
    private RadioGroup RGConversion;
    private RadioButton UStoUK;
    private RadioButton UKtoUS;
    private ImageView IVImage;
    private TextView TVConvResults;
    private EditText ETAmount;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        UStoUK = findViewById(R.id.radioButtonUSDtoUKP);
        UKtoUS = findViewById(R.id.radioButtonUKPtoUSD);
        IVImage = findViewById(R.id.imageViewConversion);
        TVConvResults = findViewById(R.id.textViewConversionResult);
        ETAmount = findViewById(R.id.editTextAmount);
        RGConversion = findViewById(R.id.radioGroupConversion);
        //click listenter
        UStoUK.setOnClickListener(setImage);
        UKtoUS.setOnClickListener(setImage);

    }
    View.OnClickListener setImage = new View.OnClickListener(){
        @Override
        public void onClick(View V) {
            if(UStoUK.isChecked()){}//IVImage.setImageResource();}//set image to us to uk
            else if(UKtoUS.isChecked()){}//set image to uk to usd

        }
    };

    public void onButtonConvertAmountClick(View view) {
        double amountDouble = 0.0;
        double convertedAmountDouble = 0.0;
        amountDouble = ETAmount.getAlpha();//convert to double not sure if works
        if(UStoUK.isChecked()){
            CurrencyConversion uSDollarToUKPoundObject = new CurrencyConversion();
        }
        else if(UKtoUS.isChecked()){
            CurrencyConversion uKPoundToUSDollarObjectObject = new CurrencyConversion();

        }
    }
}
