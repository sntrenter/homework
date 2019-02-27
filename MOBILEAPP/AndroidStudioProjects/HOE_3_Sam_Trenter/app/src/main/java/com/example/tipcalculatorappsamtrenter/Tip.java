package com.example.tipcalculatorappsamtrenter;

import android.widget.EditText;

public class Tip {

// Declare constants for all four tip percentage categories (5%, 10%, 15%, and 20%)
    static double Tip_5_PERCENT = 0.05;
    static double Tip_10_PERCENT = 0.1;
    static double Tip_15_PERCENT = 0.15;
    static double Tip_20_PERCENT = 0.20;


// Declare private fields for the tip percent, tip amount, bill subtotal, and bill total
    private double mTipPercent;
    private double mTipAmount;
    private double mBillSubtotal;
    private double mBillTotal;

// Add a constructor method to initialize all field (member variable) values to 0
    public Tip(){
        mTipPercent = 0.0;
        mTipAmount = 0.0;
        mBillSubtotal = 0.0;
        mBillTotal = 0.0;
    }

// Add two setter methods to set bill subtotal and the tip percentage
    public void setTBillSubtotal(double billSubtotalDouble){
        mBillSubtotal = billSubtotalDouble;
    }

    public void setTipPercent(double tipPercentDouble){
        mTipPercent = tipPercentDouble;
    }

// Add two getter methods to return the tip amount and the bill total\
    public double getTipAmount(){
        mTipAmount = mTipPercent*mBillSubtotal;
        return mTipAmount;
    }
    public double getBillTotal(){
        mBillTotal = mBillSubtotal+mTipAmount;
        return mBillTotal;
    }
}
