package com.example.mvpvotingmenudialogmultiactivityappsamtrenter;

import android.app.AlertDialog;
import android.app.Dialog;
import android.content.DialogInterface;
import android.os.Bundle;
import android.support.annotation.NonNull;
import android.support.annotation.Nullable;
import android.support.v4.app.DialogFragment;
import android.widget.Toast;

public class BreesFragment extends DialogFragment {
    @NonNull
    @Override
    public Dialog onCreateDialog(@Nullable Bundle savedInstanceState) {
        //return super.onCreateDialog(savedInstanceState);

        AlertDialog.Builder BreesDialog = new AlertDialog.Builder(getActivity());
        BreesDialog.setTitle("Drew Brees stats 2018");
        BreesDialog.setMessage("this \n is \n for different \n stats");
        BreesDialog.setPositiveButton("ok", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                Toast.makeText(getActivity(),"Clicked Ok", Toast.LENGTH_SHORT).show();
            }
        });
        return BreesDialog.create();
    }
}