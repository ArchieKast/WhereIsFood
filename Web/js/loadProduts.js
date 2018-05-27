$(document).ready(function(){
    $('#findForm').submit(function(){
        var data = $('input[type="text"]').val();
        $.ajax({
            url: "http://127.0.0.1:3000/",
            type: "POST",
            data: data,
            success:function(data){
                if (data[0].count !== 0){
                    $('#tiles').html('');
                    for (var i = 1; i <= data[0].count; i++){
                        var block = '<li><img src="images/product.png" width="282" height="118"><div class="post-info"><div class="post-basic-info"><h3>' + data[i].product_name +'</h3><span><a href="#">' + data[i].category_name + '</a></span><p>' + data[i].cost + '</p></div></div></li>';
                        $('#tiles').append(block);
                    }
                }
                else{
                    alert("Нет соответствий!");    
                }
            },
            error:function(){
                alert("Ошибка!");            
            }
        });
        return false;
    });
});