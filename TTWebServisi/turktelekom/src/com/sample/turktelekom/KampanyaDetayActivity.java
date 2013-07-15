package com.sample.turktelekom;


import org.ksoap2.SoapEnvelope;
import org.ksoap2.serialization.SoapObject;
import org.ksoap2.serialization.SoapSerializationEnvelope;
import org.ksoap2.transport.HttpTransportSE;

import android.os.Bundle;
import android.app.Activity;
import android.content.Intent;
import android.util.Log;
import android.view.Menu;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

public class KampanyaDetayActivity extends Activity {
	
    private final String NAMESPACE = "http://tempuri.org/";
	private final String URL = "http://10.0.2.2/Service1.asmx";
	private final String SOAP_ACTION = "http://tempuri.org/Sikayetler";
	private final String METHOD_NAME = "Sikayetler";
	
	TextView txtbaslik,txticerik;
	EditText txtsikayet,telefon;
	Button btnGonder;
	public String S_baslik,S_Icerik,S_telefon,toplam;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_kampanya_detay);
		
		Bundle extras = getIntent().getExtras();
		
		txtbaslik = (TextView)findViewById(R.id.editTextBaslik);
		txticerik = (TextView)findViewById(R.id.editTextIcerik);
		txtsikayet = (EditText)findViewById(R.id.editTextSikayet);
		telefon = (EditText)findViewById(R.id.editTextTelefon);
		btnGonder = (Button)findViewById(R.id.butonSikayet);
		
		txtbaslik.setText(extras.getString("baslik"));
		txticerik.setText(extras.getString("donusdegeriicerik"));
		S_baslik = extras.getString("baslik").toString();
	
		
		
		btnGonder.setOnClickListener(new View.OnClickListener()
		{
			public void onClick(View v)
            {
				
				Intent myIntent = new Intent(v.getContext(), Sikayet.class);
				
				S_Icerik = txtsikayet.getText().toString();
				S_telefon = telefon.getText().toString();
				
				toplam = S_baslik + "','" + S_Icerik + "','" + S_telefon;
				
				Log.d("gggggggggggggg",toplam);
							
				SoapObject request = new SoapObject(NAMESPACE, METHOD_NAME);
				request.addProperty("sikayet",toplam); 
			
				
				SoapSerializationEnvelope envelope = new SoapSerializationEnvelope(SoapEnvelope.VER11);
                
                envelope.setOutputSoapObject(request);
                envelope.dotNet = true;
                try { 
                    HttpTransportSE androidHttpTransport = new HttpTransportSE(URL);
                   
                    //this is the actual part that will call the webservice
                    androidHttpTransport.call(SOAP_ACTION, envelope);

                                    
                    
              } catch (Exception e) {
                    e.printStackTrace();
              }
                startActivity(myIntent);
            }
		});
		
		//Log.d("hm", extras.getString("donusdegeri"));
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.kampanya_detay, menu);
		return true;
	}

}
