namespace Doji.AI.Segmentation {

    /// <summary>
    /// Where HF Hub finds the MobileSAM models.
    /// </summary>
    internal static class ModelFiles {

        /// <summary>
        /// The package whose hf-hub-manifest.json selects the model files.
        /// </summary>
        internal const string PackageId = "com.doji.mobilesam";

        /// <summary>
        /// The Hugging Face repository that contains the MobileSAM ONNX exports.
        /// </summary>
        internal const string RepositoryId = "julienkay/sentis-MobileSAM";

        internal const string EncoderPath = "onnx/mobilesam.encoder.onnx";

        internal const string DecoderPath = "onnx/mobilesam.decoder.onnx";
    }
}
