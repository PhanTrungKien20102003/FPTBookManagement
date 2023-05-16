@page "/Admin/Products/Edit/{id:long}"
@page "/Admin/products/Create"
@inherits OwningComponentBase<IBookRepository>

<style>
	div.validation-message {
		color: rgb(220, 53, 69);
font - weight: 500
	}
</ style >

< div class= "container-fluid pt-4 px-4" >
	< div class= "row vh-100 bg-secondary rounded justify-content-center mx-0" >
		< div class= "mb-2 mt-4" >
			< h2 > Add new book</h2>
		</ div >
		< div class= "bg-secondary rounded h-100 p-4" >
		< EditForm Model = "Product" OnValidSubmit = "SaveBook" >
			< DataAnnotationsValidator />
			@if(Product.Id != 0)
			{
				@*      < div class= "form-group" >
			< label > ID </ label >
			< input class= " form-control" disabled value = "@Product.Id" />
			</ div > *@
				<div class= "row mb-3" >
					< label class= "form-label" > Book ID </ label >
					< input class= "form-control forInput" disabled value = "@Product.Id" >
				</ div >
			}

			@*  < div class= "form-group" >
			< label > Title </ label >
			< ValidationMessage For = "@(() => Product.Title)" />
			< InputText class= "form-control" @bind - Value = "Product.Title" />
			</ div > *@
			< div class= "row mb-3" >
				< label class= "form-label" > Title </ label >
				< ValidationMessage For = "@(() => Product.Title)" />
				< InputText class= "form-control forInput"
		 placeholder = "Title" @bind - Value = "Product.Title" />
			</ div >
@*          < div class= "form-group" >
				< ValidationMessage For = "@(() => Product.Category)" />
				< InputText class= "form-control" @bind - Value = "Product.Category" />
			</ div > *@
			< div class= "form-floating mb-3" >
				< label class= "form-label" > Category </ label >
				< select class= "form-select mb-3" aria - label = "Default select example" >
					< option selected > Select Category </ option >
					< option value = "1" > One </ option >
					< option value = "2" > Two </ option >
					< option value = "3" > Three </ option >
				</ select >
			</ div >

@*          < div class= "form-group" >
				< label > Price </ label >
				< ValidationMessage For = "@(() => Product.Price)" />
				< InputNumber class= "form-control" @bind - Value = "Product.Price" />
			</ div > *@
			< div class= "row mb-3" >
				< label class= "form-label" > Price </ label >
				< ValidationMessage For = "@(() => Product.Price)" />
				< InputNumber class= "form-control forInput" @bind - Value = "Product.Price" />
			</ div >

@*          < div class= "form-group" >
				< label > Author </ label >
				< ValidationMessage For = "@(() => Product.Author)" />
				< InputText class= "form-control" @bind - Value = "Product.Author" />
			</ div > *@
			< div class= "row mb-3" >
				< label class= "form-label" > Author </ label >
				< ValidationMessage For = "@(() => Product.Author)" />
				< InputText class= "form-control forInput" placeholder = "Author" @bind - Value = "Product.Author" />
			</ div >
@*          < div class= "form-group" >
				< label > Publisher </ label >
				< ValidationMessage For = "@(() => Product.Publisher)" />
				< InputText class= "form-control" @bind - Value = "Product.Publisher" />
			</ div > *@
			< div class= "row mb-3" >
				< label class= "form-label" > Publisher </ label >
				< ValidationMessage For = "@(() => Product.Publisher)" />
				< InputText class= "form-control forInput" placeholder = "Publisher" @bind - Value = "Product.Publisher" />
			</ div >
			< div class= "mt-2" >
					< button type = "submit" class= "btn btn-warning m-2" > Save </ button >
					< NavLink class= "btn btn-primary m-2" href = "/admin/products" > Cancel </ NavLink >
			</ div >

		</ EditForm >
		</ div >

	</ div >
</ div >

@code {
	public IBookRepository Repository => Service;

[Inject]
public NavigationManager? NavManager { get; set; }

[Parameter]
public long id { get; set; } = 0;

public Book Product { get; set; } = new Book();

protected override void OnParametersSet()
{
	if (id != 0)
	{
		Product = Repository.Books.FirstOrDefault(p => p.Id == id) ?? new();
	}
}

public void SaveBook()
{
	if (id == 0)
	{
		Repository.CreateItem(Product);
	}
	else
	{
		Repository.SaveItem(Product);
	}
	NavManager?.NavigateTo("/Admin/Products");
}
public string ThemeColor => id == 0 ? "primary" : "warning";
public string TitleText => id == 0 ? "Create" : "Edit";
}