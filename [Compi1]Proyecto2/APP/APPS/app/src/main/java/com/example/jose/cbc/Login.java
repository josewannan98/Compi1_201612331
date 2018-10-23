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

public class Login extends AppCompatActivity {

    private Button entrar;
    private Button registrar;
    private EditText email;
    private EditText contrasena;
    private ProgressBar progress;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);

        entrar = (Button) findViewById(R.id.ingresar);
        registrar = (Button) findViewById(R.id.registrar);

        email = (EditText) findViewById(R.id.correos);
        contrasena = (EditText) findViewById(R.id.contras);

        progress = (ProgressBar) findViewById(R.id.progreso);

        entrar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Ingresando();
            }
        });
        registrar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                progress.setVisibility(View.VISIBLE);
                Intent login = new Intent(getApplicationContext(), Registro.class);
                startActivity(login);
            }
        });
    }

    private void Ingresando()
    {

        progress.setVisibility(View.VISIBLE);
        String emails = email.getText().toString();
        String contras = contrasena.getText().toString();
        if(emails.contains("@")){
            if(contras.length()>4)
            {
                Intent login = new Intent(getApplicationContext(), CbC.class);
                startActivity(login);
            }
            else
            {
                LayoutInflater inflater = getLayoutInflater();
                View layout = inflater.inflate(R.layout.custom_toast,
                        (ViewGroup) findViewById(R.id.custom_toast_container));

                TextView text = (TextView) layout.findViewById(R.id.text);
                text.setText("Error - Contraseña invalida, debe contener mas de 4 caracteres");

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
                progress.setVisibility(View.INVISIBLE);

            }
        }
        else
        {
            LayoutInflater inflater = getLayoutInflater();
            View layout = inflater.inflate(R.layout.custom_toast,
                    (ViewGroup) findViewById(R.id.custom_toast_container));

            TextView text = (TextView) layout.findViewById(R.id.text);
            text.setText("Error - Email invalido");
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
            progress.setVisibility(View.INVISIBLE);

        }
    }

}
