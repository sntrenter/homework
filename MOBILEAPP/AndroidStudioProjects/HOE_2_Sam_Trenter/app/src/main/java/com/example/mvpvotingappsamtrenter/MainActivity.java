package com.example.mvpvotingappsamtrenter;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.RadioGroup;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {
    int mahomesvoteCountInteger;
    int breesVoteContInteger;

    private RadioGroup playersRadioGroup;
    private Button voteForMVPButton;
    private TextView votesTextView;




    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        playersRadioGroup = findViewById(R.id.radioGroupMVP);
        voteForMVPButton = findViewById(R.id.buttonVoteForMVP);
        votesTextView = findViewById(R.id.textVeiwMPVVotes);
    }

    public void onButtonVoteForMPVClick(View view) {
        int radioID = playersRadioGroup.getCheckedRadioButtonId();
        switch(radioID){
            case R.id.radioButtonMahomes:
                mahomesvoteCountInteger++;
                break;
            case R.id.radioButtonBrees:
                breesVoteContInteger++;
                break;
        }

        votesTextView.setText("Mahomes: "+ mahomesvoteCountInteger+"\nBrees: " + breesVoteContInteger);
        //votesTextView.append("\nBrees: " + breesVoteContInteger);
    }
}
