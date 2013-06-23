package com.sample.turktelekom;

import org.ksoap2.SoapEnvelope;
import org.ksoap2.serialization.SoapObject;
import org.ksoap2.serialization.SoapSerializationEnvelope;
import org.ksoap2.transport.HttpTransportSE;



import android.app.ListActivity;
import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;
import android.widget.AdapterView.OnItemClickListener;

public class BireyselUrunler extends ListActivity {
    /** Called when the activity is first created. */
    private final String NAMESPACE = "http://tempuri.org/";
	private final String URL = "http://10.0.2.2/Service1.asmx";
	private final String SOAP_ACTION = "http://tempuri.org/BireyselUBaslik";
	private final String SOAP_ACTION1 = "http://tempuri.org/BireyselUIcerik";
	private final String METHOD_NAME = "BireyselUBaslik";
	private final String METHOD_NAME1 = "BireyselUIcerik";
	public static String donus= "";
	public static String str2 [] = new String [10];
	@Override
	public void onCreate(Bundle savedInstanceState) { 
		super.onCreate(savedInstanceState);
         
		SoapObject request = new SoapObject(NAMESPACE, METHOD_NAME);
		
		SoapSerializationEnvelope envelope = new SoapSerializationEnvelope(SoapEnvelope.VER11);
        
        envelope.setOutputSoapObject(request);
        envelope.dotNet = true;
       
        try { 
              HttpTransportSE androidHttpTransport = new HttpTransportSE(URL); 
             
              //this is the actual part that will call the webservice
              androidHttpTransport.call(SOAP_ACTION, envelope);
             
              // Get the SoapResult from the envelope body.
              SoapObject result = (SoapObject)envelope.bodyIn;

              if(result != null)
              {
                    //Get the first property and change the label text
              	donus += result.getProperty(0).toString();
              	str2 = donus.split("#");
              	
              	Log.d("hm", donus); 
              	
                    //txtCel.setText(result.getProperty(0).toString());
              }
              else
              {
                    Toast.makeText(getApplicationContext(), "No Response",Toast.LENGTH_LONG).show();
              }
        } catch (Exception e) {
              e.printStackTrace();
        }
		
		//String[] pages = getResources().getStringArray(R.array.pages_array);
		setListAdapter(new ArrayAdapter<String>(this, R.layout.list_item, str2));
		
		ListView lv = getListView();
		
		lv.setOnItemClickListener(new OnItemClickListener() {
			public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
				
				Intent myIntent = new Intent(view.getContext(), KampanyaDetayActivity.class);
				
				if(((TextView) view).getText().equals(str2[position])){
					
					SoapObject request1 = new SoapObject(NAMESPACE, METHOD_NAME1);
					request1.addProperty("baslik",str2[position]);
					SoapSerializationEnvelope envelope = new SoapSerializationEnvelope(SoapEnvelope.VER11);
			        
			        envelope.setOutputSoapObject(request1);
			        envelope.dotNet = true;
			       
			        try { 
			              HttpTransportSE androidHttpTransport = new HttpTransportSE(URL); 
			             
			              //this is the actual part that will call the webservice
			              androidHttpTransport.call(SOAP_ACTION1, envelope);
			             
			              // Get the SoapResult from the envelope body.
			              SoapObject result1 = (SoapObject)envelope.bodyIn;

			              if(result1 != null)
			              {
			                    //Get the first property and change the label text 
			              	donus = result1.getProperty(0).toString();
			              	Log.d("hm", "-------------");
			              	Log.d("hm", result1.getProperty(0).toString());
			              	Log.d("hm", "-------------"); 
			              	myIntent.putExtra("donusdegeriicerik", donus);
			              	myIntent.putExtra("baslik", str2[position]);
			             
			              	
			                    //txtCel.setText(result.getProperty(0).toString());
			              }
			              else
			              {
			                    Toast.makeText(getApplicationContext(), "No Response",Toast.LENGTH_LONG).show();
			              }
			        } catch (Exception e) {
			              e.printStackTrace();
			        }
				
					//myIntent = new Intent(view.getContext(), BireyselKampanya.class);
				}
					
				startActivity(myIntent);

			}
		});
	}
	
}
