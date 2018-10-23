package com.example.jose.cbc;

import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.drawable.BitmapDrawable;
import android.graphics.drawable.Drawable;
import android.support.v4.graphics.drawable.RoundedBitmapDrawable;
import android.support.v4.graphics.drawable.RoundedBitmapDrawableFactory;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.Gravity;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.ProgressBar;
import android.widget.TextView;
import android.widget.Toast;

public class Registro extends AppCompatActivity {

    private EditText mail;
    private EditText contra;
    private EditText dpi;
    private EditText nom;
    private EditText ape;

    private ProgressBar progreso;

    private Button regis;
    private String email = null;
    private String contrase = null;
    private String nombres = null;
    private String apellidos = null;
    private int Dpi = -1;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_registro);

        regis = (Button) findViewById(R.id.registror);

        progreso = (ProgressBar) findViewById(R.id.prog);

        mail = (EditText) findViewById(R.id.correos);
        contra = (EditText) findViewById(R.id.contras);
        dpi = (EditText) findViewById(R.id.dpi);
        nom = (EditText) findViewById(R.id.nombre);
        ape = (EditText) findViewById(R.id.apellido);

        regis.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                progreso.setVisibility(View.VISIBLE);
                registrar();
            }
        });
    }

    private void registrar()
    {
         email = mail.getText().toString();
         contrase = contra.getText().toString();
         nombres = nom.getText().toString();
         apellidos = ape.getText().toString();
         Dpi = Integer.parseInt(dpi.getText().toString());
        if(!email.isEmpty() && !contrase.isEmpty() && !nombres.isEmpty() && !apellidos.isEmpty() && Dpi != -1)
        {
            Intent login = new Intent(getApplicationContext(), Login.class);
            startActivity(login);
        }
        else
        {
            LayoutInflater inflater = getLayoutInflater();
            View layout = inflater.inflate(R.layout.custom_toast,
                    (ViewGroup) findViewById(R.id.custom_toast_container));

            TextView text = (TextView) layout.findViewById(R.id.text);
            text.setText("Error - Todos los campos son obligatorios");

            Drawable originalDrawable = getResources().getDrawable(R.drawable.blacky);
            Bitmap originalBitmap = ((BitmapDrawable) originalDrawable).getBitmap();

            RoundedBitmapDrawable roundedDrawable =
                    RoundedBitmapDrawableFactory.create(getResources(), originalBitmap);

            roundedDrawable.setCornerRadius(originalBitmap.getHeight());


            ImageView img = (ImageView) layout.findViewById(R.id.imgs);
            img.setImageDrawable(roundedDrawable);

            Toast toast = new Toast(getApplicationContext());
            toast.setGravity(Gravity.CENTER_VERTICAL, 0, 0);
            toast.setDuration(Toast.LENGTH_LONG);
            toast.setView(layout);
            toast.show();
            progreso.setVisibility(View.INVISIBLE);
        }
    }
}
