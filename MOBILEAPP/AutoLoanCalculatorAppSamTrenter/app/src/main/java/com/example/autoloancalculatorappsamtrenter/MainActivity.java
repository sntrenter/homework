package com.example.autoloancalculatorappsamtrenter;

import android.content.Intent;
import android.support.v4.app.DialogFragment;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.RadioGroup;

import static java.lang.Double.parseDouble;

public class MainActivity extends AppCompatActivity {


    //Declare UI Stuff
    public EditText ETCarPrice;
    public EditText ETDownPayment;
    public RadioGroup RGLoanTerm;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        // Get reference to the two EditText controls and the one RadioGroup contro
        //from the UI and store those using the objects you declared earlier
        ETCarPrice = findViewById(R.id.editTextCarPrice);
        ETDownPayment = findViewById(R.id.editTextDownPayment);
        RGLoanTerm = findViewById(R.id.radioGroupLoanTerm);
    }

    public void onButtonGenerateLoanSummaryClick(View view) {
        //instantiate a new autoloan object to store autoloan info
        AutoLoan autoLoan = new AutoLoan();
        //get car price and down payment
        double carPrice = parseDouble(ETCarPrice.getText().toString());
        double downPayment = parseDouble(ETDownPayment.getText().toString());
        //set the classes things from our numbers
        autoLoan.setCarPrice(carPrice);
        autoLoan.setDownPayment(downPayment);
        //check loan term
        int radioID = RGLoanTerm.getCheckedRadioButtonId();

        //set loan term
        RadioButton loanTermRB = findViewById(radioID);

        autoLoan.setLoanTerm(loanTermRB.getText().toString());
        autoLoan.setTaxAmount();
        autoLoan.setTotalCost();
        autoLoan.setBorrowedAmount();
        autoLoan.setMonthlyPayment();
        autoLoan.setInterestAmount();
        autoLoan.setLoanSummary();


        //formate the monthly payment using getter method
        String monthlyPaymentString = "temp";
        String loanSummaryString = autoLoan.getLoanSummary();
        //intent object
        Intent LaunchLoanSummaryIntent = new Intent(this,LoanSummanryActivity.class);
        LaunchLoanSummaryIntent.putExtra("montlyPayment",monthlyPaymentString);
        LaunchLoanSummaryIntent.putExtra("LoanSummary",loanSummaryString);
        //pass the values to the next activity

        //start activity method
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        //return super.onCreateOptionsMenu(menu);
        getMenuInflater().inflate(R.menu.my_menu,menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        //return super.onOptionsItemSelected(item);

        int id = item.getItemId();
        if(id == R.id.action_about){
            DialogFragment aboutFragment = new DialogFragment();
            aboutFragment.show(getSupportFragmentManager(),"aboutDialog");
            return true;
        }
        else if(false){}
        return true;
    }
}
