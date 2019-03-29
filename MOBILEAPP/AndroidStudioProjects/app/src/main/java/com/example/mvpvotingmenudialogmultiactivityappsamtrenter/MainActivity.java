package com.example.mvpvotingmenudialogmultiactivityappsamtrenter;

import android.content.Intent;
import android.support.v4.app.DialogFragment;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.RadioGroup;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {
    int mahomesVoteCountInteger = 0;
    int breesVoteCountInteger = 0;


    private RadioGroup rgMVP;
    private TextView tvMPVVOTES;
    private Button bVote;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        rgMVP = findViewById(R.id.radioGroupMVP);
        bVote = findViewById(R.id.buttonVoteForMVP);
        tvMPVVOTES = findViewById(R.id.textViewMVPVotes);
    }

    public void onButtonVoteForMVPClick(View view) {
        int radioID = rgMVP.getCheckedRadioButtonId();

        switch (radioID)
        {
            case R.id.radioButtonBrees:
                breesVoteCountInteger++;
                tvMPVVOTES.setText("Mohomes votes: " + mahomesVoteCountInteger);
                tvMPVVOTES.append("\nBrees votes: "+breesVoteCountInteger);
                break;
            case R.id.radioButtonMahomes:
                mahomesVoteCountInteger++;
                tvMPVVOTES.setText("Mohomes votes: " + mahomesVoteCountInteger);
                tvMPVVOTES.append("\nBrees votes: "+breesVoteCountInteger);
                break;
        }
    }

    public void onButtonFindMVPWinnerClick(View view) {
        String mVPWinnerString;
        if(mahomesVoteCountInteger>breesVoteCountInteger)
        {
            mVPWinnerString = "Patrick Mohomes";
        }else
            {
                mVPWinnerString = "Drew Brees";
            }
            Intent passMVPWinnerToSecondActivity = new Intent(this,SecondActivity.class);
        passMVPWinnerToSecondActivity.putExtra("Winner",mVPWinnerString);
        startActivity(passMVPWinnerToSecondActivity);

    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        //return super.onCreateOptionsMenu(menu);
        getMenuInflater().inflate(R.menu.my_menu,menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {


        int id = item.getItemId();
        if(id == R.id.action_mahomes_stats){
            DialogFragment mahomesFragment = new MahomeFragment();
            mahomesFragment.show(getSupportFragmentManager(),"mahomesDialog");
        }else if (id == R.id.action_brees_stats){
            DialogFragment mahomesFragment = new MahomeFragment();
            mahomesFragment.show(getSupportFragmentManager(),"mahomesDialog");

        }

        return super.onOptionsItemSelected(item);
    }
}
