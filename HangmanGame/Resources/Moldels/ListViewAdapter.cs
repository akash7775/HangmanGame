using Android.App;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;

namespace HangmanGame.Resources.Moldels
{
    public class ViewHolder 
    {
        public TextView txtWords { get; set; }
        public TextView txtHints { get; set; }
    }
    public class ListViewAdapter : BaseAdapter
    {
        private Activity activity;
        private List<Word> listword;
        public ListViewAdapter(Activity activity, List<Word> listWord)
        {
            this.activity = activity;
            this.listword = listWord;
        }

        public override int Count
        {
            get { return listword.Count; }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return listword[position].WordID;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView ?? activity.LayoutInflater.Inflate(Resource.Layout.list_view, parent, false);
            var txtText= view.FindViewById<TextView>(Resource.Id.wordView) ?? new TextView(parent.Context);
            var txtHint = view.FindViewById<TextView>(Resource.Id.hintView) ?? new TextView(parent.Context);
            txtText.Text = listword[position].text;
            txtHint.Text = "Hint : " + listword[position].hint;
            return view;
        }
    }
}