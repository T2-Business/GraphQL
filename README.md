# GraphQL

GraphQL is a modern replacement for the  REST API server.
This is a pure GraphQL server application example with .net core and <a href="https://github.com/ChilliCream/hotchocolate">HotChocolate</a> 


Query Examples
query{
  blogs{
     articles{
       body, 
       createDate, 
       subject
     }, 
author{
  age, 
  id, 
  name, 
  blogs{
    id,
    name,
    createDate 
    author{
      id, 
      name
    }
  }
}
    
  }
  
}


<h2>GraphQL Clients</h2>
<p>Your client application will need a <code>GraphQL client</code> to communicate with a GraphQL server. You can also use a raw browser's <code>fetch</code> to post data to the GraphQL server.</p>
<p>Some Popular GraphQL clients :</p>
<ul>
<li><a href="https://github.com/apollostack/apollo-client">apollo-client</a></li>
<li><a href="https://github.com/gucheen/FetchQL">FetchQL</a></li>
<li><a href="https://github.com/kadirahq/lokka">lokka</a></li>
<\ul>
<h3>Alos you can Add your Own client applicaiton <h3>
