using Xamarin.Forms;
using Contentful.Core;
using System.Net.Http;
using System.Threading.Tasks;
using Contentful.Core.Search;
using Contentful.Core.Models;

namespace ContentfulFormsTest
{
    public partial class ContentfulFormsTestPage : ContentPage
    {
        public ContentfulFormsTestPage()
        {
            InitializeComponent();
            getLabel();
        }

        public async Task getLabel() {
            var httpClient = new HttpClient();
            var client = new ContentfulClient(httpClient, "Your Contentful's Key", "Your Contentful's Space Id");
            var entry = await client.GetEntryAsync<Entry<dynamic>>("Your Entry's Id");
            textLabel.Text = entry.Fields.encabezado.ToString();
        }
    }
}
