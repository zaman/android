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
public class HomeList1 extends ListActivity {
	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		String[] pages = getResources().getStringArray(R.array.pages_array1);
		setListAdapter(new ArrayAdapter<String>(this, R.layout.list_item, pages));
		ListView lv = getListView();
		lv.setOnItemClickListener(new OnItemClickListener() {
			public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
				Intent myIntent = null;
				if(((TextView) view).getText().equals("Bireysel")){
					myIntent = new Intent(view.getContext(), HomeListView.class);
				}
				
				if(((TextView) view).getText().equals("Kurumsal")){
					myIntent = new Intent(view.getContext(), HomeListView2.class);
				}
				
				if(((TextView) view).getText().equals("Duyurular")){
					myIntent = new Intent(view.getContext(), HomeListView3.class);
				}
				startActivity(myIntent);
			}
		});
	}

}
