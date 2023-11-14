using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Factory
{
    public class ProductA : MonoBehaviour, IProduct
    {
        [SerializeField] private string productName = "ProductA";
        public string ProductName { get; set; }

        private ParticleSystem particleSystem;

        public void Initialize()
        {
            // any unique logic to this product
            gameObject.name = productName;
            particleSystem = GetComponentInChildren<ParticleSystem>();
            particleSystem?.Stop();
            particleSystem?.Play();
        }
    }
}
