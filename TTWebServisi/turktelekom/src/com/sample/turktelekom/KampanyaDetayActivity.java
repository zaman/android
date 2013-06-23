package com.sample.turktelekom;


import android.os.Bundle;
import android.app.Activity;
import android.util.Log;
import android.view.Menu;
import android.widget.EditText;

public class KampanyaDetayActivity extends Activity {
	
	EditText txtbaslik,txticerik;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_kampanya_detay);
		
		Bundle extras = getIntent().getExtras();
		
		txtbaslik = (EditText)findViewById(R.id.editTextBaslik);
		txticerik = (EditText)findViewById(R.id.editTextIcerik);
		
		txtbaslik.setText(extras.getString("baslik"));
		txticerik.setText(extras.getString("donusdegeriicerik"));
		
		
		//Log.d("hm", extras.getString("donusdegeri"));
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.kampanya_detay, menu);
		return true;
	}

}
