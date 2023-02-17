using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Specialized;

var connectionString = "";

BlobServiceClient? blobServiceClient = new BlobServiceClient(connectionString);

var source = "firstcontainer";
var destination = "secondcontainer";
var sourcefile = "Book1.pdf";
var destfile = "Book1-COPY.pdf";

var sourceClient = new BlockBlobClient(connectionString, source, sourcefile);
var destinationClient = new BlockBlobClient(connectionString, destination, destfile);

await destinationClient.StartCopyFromUriAsync(sourceClient.Uri);