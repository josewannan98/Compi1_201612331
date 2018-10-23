package com.example.jose.cbc;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;

public class MainActivity extends AppCompatActivity implements  Runnable{

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        hilo.start();
    }
    int segundos = 0;
    Thread hilo = new Thread(this);
    @Override
    public void run() {
        while (segundos < 2) {
            try {

                Thread.sleep(2000);

                segundos++;


            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        }
        Intent login = new Intent(getApplicationContext(), Login.class);
        startActivity(login);


    }
}
