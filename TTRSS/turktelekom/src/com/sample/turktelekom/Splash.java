package com.sample.turktelekom;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;

public class Splash extends Activity {

	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.splash);

		// Thread haz�rlan�yor
		Thread thread = new Thread() {

			@Override
			public void run() {

				try {
					synchronized (this) {

						wait(3000);
					}
				} catch (InterruptedException e) {


				} finally {

					finish();

					Intent intent = new Intent();
					intent.setClass(getApplicationContext(), HomeList1.class);
					startActivity(intent);

				}

			}
		};

		// Thread ba�lat�l�yor
		thread.start();

	}
}
