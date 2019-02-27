package com.example.tipcalculatorappsamtrenter;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.RadioGroup;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    private RadioGroup tipPercentRG;
    private EditText billSubtotalET;
    private TextView tipAmountResultTV;
    private TextView billTotalTV;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        tipPercentRG = findViewById(R.id.radioGroupTipPercent);
        billSubtotalET = findViewById(R.id.editTextBillSubtotal);
        tipAmountResultTV = findViewById(R.id.textViewTipAmountResult);
        billTotalTV = findViewById(R.id.textViewBillTotal);
    }

    public void onButtonCalculateTipClick(View view) {




        Tip tipObject = new Tip();
        double billSubtotalDouble = Double.parseDouble(billSubtotalET.getText().toString());
        tipObject.setTBillSubtotal(billSubtotalDouble);


        int radioID;

        radioID = tipPercentRG.getCheckedRadioButtonId();

        switch(radioID){
            case R.id.radioButtonTip5Percent:
                tipObject.setTipPercent(Tip.Tip_5_PERCENT);
                break;
            case R.id.radioButtonTip10Percent:
                tipObject.setTipPercent(Tip.Tip_10_PERCENT);
                break;
            case R.id.radioButtonTip15Percent:
                tipObject.setTipPercent(Tip.Tip_15_PERCENT);
                break;
            case R.id.radioButtonTip20Percent:
                tipObject.setTipPercent(Tip.Tip_20_PERCENT);
                break;

        }


        tipAmountResultTV.setText("$"+tipObject.getTipAmount());
        billTotalTV.setText("$"+ tipObject.getBillTotal());
    }
}
