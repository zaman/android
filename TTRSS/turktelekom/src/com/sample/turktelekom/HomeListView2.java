package com.sample.turktelekom;

import android.app.ListActivity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.AdapterView.OnItemClickListener;

public class HomeListView2 extends ListActivity {
    /** Called when the activity is first created. */
	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		
		String[] pages = getResources().getStringArray(R.array.pages_array);
		setListAdapter(new ArrayAdapter<String>(this, R.layout.list_item, pages));
		
		ListView lv = getListView();
		
		lv.setOnItemClickListener(new OnItemClickListener() {
			public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
				
				Intent myIntent = null;
				
				if(((TextView) view).getText().equals("Kampanyalar")){
					myIntent = new Intent(view.getContext(), KurumsalKampanyalar.class);
				}
				
				if(((TextView) view).getText().equals("Ürünler")){
					myIntent = new Intent(view.getContext(), KurumsalUrunler.class);
				}

				if(((TextView) view).getText().equals("Tarifeler")){
					myIntent = new Intent(view.getContext(), KurumsalTarifeler.class);
				}


				startActivity(myIntent);

			}
		});
	}

}
