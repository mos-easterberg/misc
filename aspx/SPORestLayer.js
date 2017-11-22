function getListItems(webURL){
	var results;
	$.ajax({
		url: webURL,
		method: "GET",
		async: false,
		headers: { "Accept": "application/json; odata=verbose" },
		success: function (data) {
			if (data.d.results.length > 0 ) {
				results = data.d.results;
			}       
		},
		error: function (data) {
        	alert("Error: "+ data);
        }
        
	});
	return results;
}
