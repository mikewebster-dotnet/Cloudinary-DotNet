using System.Runtime.CompilerServices;

// Makes internals visible to unit test project
#if SIGN_ASSEMBLY
[assembly: InternalsVisibleTo("CloudinaryDotNet.Tests, PublicKey=00240000048000009400000006020000002400005253413100040000010001004dd0cacc2cbf7a5933bd5cddf82e397d4a05db7c46af9cdd0d5e40485e6db5472b1677c8445928438b2a283f6de438993a0ec7ab757de45e48bc7817b3b894eeb7e3b767fe98832a59d3cbdf2d224dfadf66be5d3b5e196395a238faa31923e52816da13d31464ce7bcdc9987e06bf8187786229fafdc2e4ae9b74319f8004b0")]
[assembly: InternalsVisibleTo("CloudinaryDotNet.IntegrationTests, PublicKey=00240000048000009400000006020000002400005253413100040000010001004dd0cacc2cbf7a5933bd5cddf82e397d4a05db7c46af9cdd0d5e40485e6db5472b1677c8445928438b2a283f6de438993a0ec7ab757de45e48bc7817b3b894eeb7e3b767fe98832a59d3cbdf2d224dfadf66be5d3b5e196395a238faa31923e52816da13d31464ce7bcdc9987e06bf8187786229fafdc2e4ae9b74319f8004b0")]
#else
[assembly: InternalsVisibleTo("CloudinaryDotNet.Tests")]
[assembly: InternalsVisibleTo("CloudinaryDotNet.IntegrationTests")]
#endif
