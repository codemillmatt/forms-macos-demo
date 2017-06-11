using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Forms4Mac
{
    public class ListviewSelectedItemBehavior : Behavior<ListView>
    {
		public static readonly BindableProperty CommandProperty =
				BindableProperty.Create("Command", typeof(ICommand), typeof(ListviewSelectedItemBehavior), null);
		public static readonly BindableProperty InputConverterProperty =
				BindableProperty.Create("Converter", typeof(IValueConverter), typeof(ListviewSelectedItemBehavior), null);

		public ICommand Command
		{
			get { return (ICommand)GetValue(CommandProperty); }
			set { SetValue(CommandProperty, value); }
		}

		public IValueConverter Converter
		{
			get { return (IValueConverter)GetValue(InputConverterProperty); }
			set { SetValue(InputConverterProperty, value); }
		}

		public ListView AssociatedObject { get; private set; }

		protected override void OnAttachedTo(ListView bindable)
		{
			base.OnAttachedTo(bindable);
			AssociatedObject = bindable;
			bindable.BindingContextChanged += OnBindingContextChanged;
			bindable.ItemSelected += OnListViewItemSelected;
		}

		protected override void OnDetachingFrom(ListView bindable)
		{
			base.OnDetachingFrom(bindable);
			bindable.BindingContextChanged -= OnBindingContextChanged;
			bindable.ItemSelected -= OnListViewItemSelected;
			AssociatedObject = null;
		}

		void OnBindingContextChanged(object sender, EventArgs e)
		{
			OnBindingContextChanged();
		}

		void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var listView = sender as ListView;

			if (listView == null)
				return;

			if (listView.SelectedItem == null)
				return;

			if (Command == null)
			{
				return;
			}
                        		
			if (Command.CanExecute(e.SelectedItem))
			{
				Command.Execute(e.SelectedItem);
			}

			listView.SelectedItem = null;
		}

		protected override void OnBindingContextChanged()
		{
			base.OnBindingContextChanged();
			BindingContext = AssociatedObject.BindingContext;
		}
    }
}
