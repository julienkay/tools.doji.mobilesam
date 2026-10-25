using System.IO;
using NUnit.Framework;
using UnityEngine;

namespace Doji.AI.Segmentation.Editor.Tests
{
    /// <summary>
    /// The paths the code loads must be the ones hf-hub-manifest.json selects, or loading fails at runtime.
    /// </summary>
    public sealed class ModelFilesTests
    {
        const string ManifestPath = "Packages/com.doji.mobilesam/hf-hub-manifest.json";

        [System.Serializable]
        class Manifest
        {
            public int version;
            public ManifestModel[] models;
        }

        [System.Serializable]
        class ManifestModel
        {
            public string id;
            public ManifestFile[] files;
        }

        [System.Serializable]
        class ManifestFile
        {
            public string path;
            public bool optional;
        }

        [Test]
        public void Manifest_SelectsTheFilesTheCodeLoads()
        {
            var manifest = JsonUtility.FromJson<Manifest>(File.ReadAllText(ManifestPath));

            Assert.That(manifest.models, Has.Length.EqualTo(1));
            var model = manifest.models[0];
            Assert.That(model.id, Is.EqualTo(ModelFiles.RepositoryId));
            Assert.That(model.files, Has.Some.Matches<ManifestFile>(f => f.path == ModelFiles.EncoderPath && !f.optional));
            Assert.That(model.files, Has.Some.Matches<ManifestFile>(f => f.path == ModelFiles.DecoderPath && !f.optional));
        }

        [Test]
        public void ModelFiles_UsesThePackageId()
        {
            Assert.That(ModelFiles.PackageId, Is.EqualTo("com.doji.mobilesam"));
        }
    }
}
