$(document).ready(function() {
  $(".edit-article-button").click(function() {
    var currentArticle = $(this).val();
    var articleDisplayString = "#display-article-" + currentArticle;
    var articleEditString = "#edit-article-" + currentArticle;
    var articleSavedString = "#saved-article-" + currentArticle;
    $(articleDisplayString).hide();
    $(articleSavedString).hide();
    $(articleEditString).show();
  })

  $(".save-article-button").click(function() {
    var currentArticle = $(this).val();
    var articleEditString = "#edit-article-" + currentArticle;
    var articleSavedString = "#saved-article-" + currentArticle;
    $(articleEditString).hide();
    $(articleSavedString).show();
  })
})
