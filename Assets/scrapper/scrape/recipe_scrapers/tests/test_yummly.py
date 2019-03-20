import os
import unittest

from recipe_scrapers.yummly import Yummly


class TestYummlyScraper(unittest.TestCase):
    def setUp(self):
        # tests are run from tests.py
        with open(os.path.join(
            os.getcwd(),
            'recipe_scrapers',
            'tests',
            'test_data',
            'yummly.testhtml'
        )) as file_opened:
            self.harvester_class = Yummly(file_opened, test=True)

    def test_host(self):
        self.assertEqual(
            'yummly.com',
            self.harvester_class.host()
        )

    def test_title(self):
        self.assertEqual(
            self.harvester_class.title(),
            'Carrot Milk shake'
        )

    def test_total_time(self):
        self.assertEqual(
            30,
            self.harvester_class.total_time()
        )

    def test_ingredients(self):
        self.assertSetEqual(
            set([
                '3 teaspoons sugar (can add more if you want it sweeter)',
                '4 cashew (badam or pista, for garnishing)',
                '1 1/2 cups milk',
                '100 grams carrot (4 baby carrots in number or 1 big size)',
                '1 cardamom (small, powdered)'
            ]),
            set(self.harvester_class.ingredients())
        )

    def test_instructions(self):
        return self.assertEqual(
            '',
            self.harvester_class.instructions()
        )
