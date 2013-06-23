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

public class HomeListView3 extends ListActivity {
    /** Called when the activity is first created. */
	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		
		String[] pages = getResources().getStringArray(R.array.pages_array2);
		setListAdapter(new ArrayAdapter<String>(this, R.layout.list_item, pages));
		
		ListView lv = getListView();
		
		lv.setOnItemClickListener(new OnItemClickListener() {
			public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
				
				Intent myIntent = null;
				
				if(((TextView) view).getText().equals("Bas›n Bülteni")){
					myIntent = new Intent(view.getContext(), Basin.class);
				}
				
				if(((TextView) view).getText().equals("Sponsorluk")){
					myIntent = new Intent(view.getContext(), Sponsorluk.class);
				}

				if(((TextView) view).getText().equals("‹nsan Kaynaklar›")){
					myIntent = new Intent(view.getContext(), InsanKaynaklari.class);
				}

				if(((TextView) view).getText().equals("‹hale ‹lani")){
					myIntent = new Intent(view.getContext(), IhaleIlani.class);
				}
				
				if(((TextView) view).getText().equals("Sosyal Sorumluluk")){
					myIntent = new Intent(view.getContext(), SosyalSorumluluk.class);
				}

				startActivity(myIntent);

			}
		});
	}

}
