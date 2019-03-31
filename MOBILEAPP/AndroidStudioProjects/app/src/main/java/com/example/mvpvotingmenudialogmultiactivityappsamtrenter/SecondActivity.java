package com.example.mvpvotingmenudialogmultiactivityappsamtrenter;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

public class SecondActivity extends AppCompatActivity {
    private TextView winnerTV;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_second);
        winnerTV = findViewById(R.id.textViewWinner);
        Intent getWinnerFromMainActivityIntent = getIntent();
        String winnerReceivedFromMainActivity;
        winnerReceivedFromMainActivity = getWinnerFromMainActivityIntent.getStringExtra("Winner");
        winnerTV.setText("Your MPV is: \n " + winnerReceivedFromMainActivity);
    }

    public void onButtonBackToMainActivityClick(View view) {
        finish();

    }
}
